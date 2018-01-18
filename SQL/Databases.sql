--
-- PostgreSQL database dump
--

-- Dumped from database version 9.3.18
-- Dumped by pg_dump version 9.3.18
-- Started on 2018-01-13 06:17:36

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

DROP DATABASE otf_invoice;
--
-- TOC entry 1977 (class 1262 OID 16550)
-- Name: otf_invoice; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE otf_invoice WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';


ALTER DATABASE otf_invoice OWNER TO postgres;

\connect otf_invoice

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- TOC entry 1 (class 3079 OID 11750)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 1980 (class 0 OID 0)
-- Dependencies: 1
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

--
-- TOC entry 171 (class 1259 OID 18442)
-- Name: invoiced_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE invoiced_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.invoiced_seq OWNER TO postgres;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 177 (class 1259 OID 18496)
-- Name: invoice; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE invoice (
    invoiceid integer DEFAULT nextval('invoiced_seq'::regclass) NOT NULL,
    nomorinvoice character varying(6) NOT NULL,
    duedate date,
    outletcode character varying(20),
    subtotal numeric(19,4),
    ppn double precision,
    total numeric(19,4),
    issueddate date,
    isppn boolean,
    nomorpo character varying(10),
    periode character varying(7),
    pengguna character varying(10),
    idpayment character varying(15),
    ispayed boolean
);


ALTER TABLE public.invoice OWNER TO postgres;

--
-- TOC entry 178 (class 1259 OID 18537)
-- Name: invoicedetail; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE invoicedetail (
    invoiceid integer NOT NULL,
    itemcode character varying(15) NOT NULL,
    itemqty integer,
    discount real,
    itemprice numeric(19,4),
    subtotal numeric(19,4)
);


ALTER TABLE public.invoicedetail OWNER TO postgres;

--
-- TOC entry 175 (class 1259 OID 18474)
-- Name: invoicedetail_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE invoicedetail_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.invoicedetail_seq OWNER TO postgres;

--
-- TOC entry 172 (class 1259 OID 18455)
-- Name: outlet; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE outlet (
    outlcode character varying(10) NOT NULL,
    outlname character varying(100),
    outladdress character varying(200),
    outlslsm character varying(10),
    outlroute character varying(5),
    outlstat boolean
);


ALTER TABLE public.outlet OWNER TO postgres;

--
-- TOC entry 176 (class 1259 OID 18482)
-- Name: product; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE product (
    itemcode character varying(10) NOT NULL,
    itemname character varying(50),
    itemsort character(5),
    brand character varying(20),
    jenis character varying(30),
    category character varying(25),
    subcategory character varying(50),
    price numeric(19,4),
    stat boolean
);


ALTER TABLE public.product OWNER TO postgres;

--
-- TOC entry 173 (class 1259 OID 18458)
-- Name: salesman; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE salesman (
    slsmcode character varying(15) NOT NULL,
    slsmname character varying(50),
    slsmaddress character varying(100),
    slsmtelp character varying(20),
    slsmsupv character varying(15),
    slsmphoto character varying(200),
    stat boolean
);


ALTER TABLE public.salesman OWNER TO postgres;

--
-- TOC entry 174 (class 1259 OID 18463)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE users (
    userid character varying(20) NOT NULL,
    username character varying(50) NOT NULL,
    password character varying(50),
    authlevel character varying(10),
    joineddate date NOT NULL
);


ALTER TABLE public.users OWNER TO postgres;

--
-- TOC entry 1971 (class 0 OID 18496)
-- Dependencies: 177
-- Data for Name: invoice; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO invoice VALUES (63, '0010', '2018-01-12', '201801', 2668500.0000, 0, 2668500.0000, '2018-01-05', false, NULL, '0118', 'admin', NULL, false);
INSERT INTO invoice VALUES (61, '7878', '2017-12-31', '713290302', 31892500.0000, 3189250, 35081750.0000, '2017-12-01', true, 'po3233', '6686', 'dadad', '9090', false);
INSERT INTO invoice VALUES (62, '1992', '2018-01-14', '80989', 25734375.0000, 2573437.5, 28307812.5000, '2018-01-31', true, NULL, '0118', 'admin', NULL, true);


--
-- TOC entry 1981 (class 0 OID 0)
-- Dependencies: 171
-- Name: invoiced_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('invoiced_seq', 63, true);


--
-- TOC entry 1972 (class 0 OID 18537)
-- Dependencies: 178
-- Data for Name: invoicedetail; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO invoicedetail VALUES (63, 'FG201001', 593, 25, 6000.0000, 2668500.0000);
INSERT INTO invoicedetail VALUES (61, 'fg100000', 5000, 0, 2000.0000, 10000000.0000);
INSERT INTO invoicedetail VALUES (61, 'FG201003', 4665, 0, 4500.0000, 20992500.0000);
INSERT INTO invoicedetail VALUES (61, 'FG00012', 100, 25, 12000.0000, 900000.0000);
INSERT INTO invoicedetail VALUES (62, 'FG0001', 444, 25, 12000.0000, 3996000.0000);
INSERT INTO invoicedetail VALUES (62, 'FG201003', 900, 22, 4000.0000, 2808000.0000);


--
-- TOC entry 1982 (class 0 OID 0)
-- Dependencies: 175
-- Name: invoicedetail_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('invoicedetail_seq', 33, true);


--
-- TOC entry 1966 (class 0 OID 18455)
-- Dependencies: 172
-- Data for Name: outlet; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO outlet VALUES ('80989', 'toko aisyah', 'Address', '89789798', 'F00', true);
INSERT INTO outlet VALUES ('201801', 'CATERING ALYA', 'JL. Antilop Raya, Cikarang Baru', '31233', 'F02', true);
INSERT INTO outlet VALUES ('713290386', 'RAINI SNACK', 'JL. TOL JAKARTA-CIKAMPEK REST AREA NO. 19', '71329900', 'F21', true);
INSERT INTO outlet VALUES ('713290387', 'TOKO NESCAFE', 'JL. TOL JAKARTA-CIKAMPEK REST AREA KM NO. 19', '71329900', 'F21', true);
INSERT INTO outlet VALUES ('713290388', 'TOKO COFFE ODEL', 'JL. TOL JAKARTA-CIKAMPEK REST AREA NO. 19', '71329900', 'F21', true);
INSERT INTO outlet VALUES ('713290385', 'KANTIN PEMKAB BEKASI DISDIK', 'JL. KOMPLEK PEMDA KABUPATEN BEKASI NO. 2 GEDUNG A2', '71329900', 'F21', true);
INSERT INTO outlet VALUES ('713290389', 'KANTIN PT.MITSUBISHI', 'KAWASAN GIIC JL. UTAMA NO. 1 CIKARANG PUSAT 17330', '71329900', 'F21', true);
INSERT INTO outlet VALUES ('713290366', 'BAZAR', 'JL. VILLA MUTIARA BLOK H 18 NO. 2 CIKARANG SELATAN', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290381', 'CATERING RMA', 'KAWASAN EJIP JALAN NO. 1', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290360', ' Kop.Mulia Industry depan', 'jl. raya tegal gede  NO.15 lemahabang 17550

cikarang - bekasi', '71329900', 'F31', true);
INSERT INTO outlet VALUES ('713290361', 'Kop. mulia industry MGF', 'Jl. Raya Tegal Gede NO.14 ,Mulia Industry Complex, Lemah Abang, Cikarang, Jawa Barat 17550', '71329900', 'F31', true);
INSERT INTO outlet VALUES ('713290362', 'Kop. Mulia Industry MKIR', 'Jl. Raya Tegal Gede,Mulia NO.15 Lemah Abang, Cikarang, Jawa Barat 17550', '71329900', 'F31', true);
INSERT INTO outlet VALUES ('713290104', 'KANTIN RS HOSANA MEDIKA', 'JL UTAMA B II E NO. 1 KAWASAN HYUNDAI', '71329900', 'F21', true);
INSERT INTO outlet VALUES ('713290363', 'Kop. Mulia Industry MGC', 'Jl. Raya Tegal Gede NO.13,Mulia Industry Complex, Lemah Abang, Cikarang, Jawa Barat 17550', '71329900', 'F31', true);
INSERT INTO outlet VALUES ('713290320', 'SOWA', 'JL. JABABEKA VI KAV. 28-36 NO. 43, JABABEKA INDUSTRIAL PARK,  CIKARANG SELATAN, BEKASI,JAWA BARAT 17530', '71329900', 'F21', true);
INSERT INTO outlet VALUES ('713290369', 'PT. AKZO NOBEL', 'JL. JABABEKA RAYA Blok E 9 - 11 NO. 11 CIKARANG INDUSTRIAL ESTATE, CIKARANG UTARA, BEKASI, Jawa Barat 17530', '71329900', 'F31', true);
INSERT INTO outlet VALUES ('713290370', 'PT. ARROHA', 'JL. DELTAMAS BOULEVARD NO.8 BLOK L 2, SUKARESMI, CIKARANG SELATAN, BEKASI', '71329900', 'F31', true);
INSERT INTO outlet VALUES ('713290375', 'PT YAMANI SPRING INDONESIA', 'EJIP INDUSTRIAL PARK PLOT NO. 8C/A1-A2, JL. CIUJUNG, DESA SUKARESMI, CIKARANG SELATAN', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290017', 'PT CALPIS ( AJINOMOTO )', 'JL CISOKAN IV FLOT NO. 7C KAWASAN INDUSTRI EJIP

CIKARANG SELATAN', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290002', 'RESTU CAHYA', 'JLN PERUM MUTIARA RT 08 RW 05 NO. 19', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290051', 'CATTERING CV. SUMI', 'JL KP. KUKUN DS.CIANTRA NO. 12  RT. 12 /06 CIKARANG SELATAN  DEKAT TUKANG MIAYAM', '71329900', 'F31', true);
INSERT INTO outlet VALUES ('713290082', 'PT MITSUBISHI', 'Kawasan Bekasi International Industrial Estate, Jl. Raya Inti Blok C11 No. 1, Lemah Abang, Cikarang Selatan, Bekasi,  17550', '71329900', 'F21', true);
INSERT INTO outlet VALUES ('713290089', 'TOKO MANDALA SENTOSA MAD', 'JLN.PERUM TAMAN SENTOSA BLOK M10 NO. 17

CIKARANG SELATAN', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290179', 'KOP LG INNOTEK', 'JALAN INTI I BLOK C1 NO. 3, CIKARANG SELATAN, BEKASI, 17530', '71329900', 'F21', true);
INSERT INTO outlet VALUES ('713290182', 'HONDA LOGISTIK', 'JL. kawasan deltamas blok k no 7-10 ,SUKAMAHI CIKARANG PUSAT', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290298', 'KIRANA YPMI', 'JLN. MH. THAMRIN LIPPO CIKARANG RUKO UNION BLOK B 12 NO 15', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290299', 'KIRANA WJ', 'JL. M.H THAMRIN LIPPO CIKARANG RUKO UNION BLOK B 12 NO. 15', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290300', 'SMAP', 'JL AKASIA 2 BLOK AE NO. 47 KAWASAN DELTA SILIKON 1  SUKARESMI, CIKARANG SELATAN', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290301', 'AISIN 1', 'JL. CITANDUY RAYA BLOK PLAT 6 NO. 5, SUKARESMI, CIKARANG SEL., BEKASI, JAWA BARAT 17530 KAWASAN EJIP KAV 5 J', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290302', 'SAKURA 1', 'JL KAWASAN EJIP PLOT NO. 5E SUKARESMI, CIKARANG SELATAN', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290303', 'HI TECH', 'JL. AKASIA 2 KAWASAN DELTA SILIKON 1 BLOK NO. 8A - 2 SUKARESMI, CIKARANG SELATAN', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290304', 'PAMERAN', 'JALAN VILLA MUTIARA H12 NO. 2 CIKARANG SELATAN', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290325', 'KATERING SURYA / RAHAYU', ' JLN.PERUM VILLA MUTIARA KP KUKUN DS CIANTRA RT 11 / 06 NO. 112

CIKARANG SELATAN', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290344', 'AISIN 2', 'JL. CITANDUY RAYA BLOK PLAT 6 NO. 5, SUKARESMI, CIKARANG SEL., BEKASI, JAWA BARAT 17530 KAWASAN EJIP KAV 5 J', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290345', 'AISIN 3', 'JL. CITANDUY RAYA BLOK PLAT 6 NO. 5, SUKARESMI, CIKARANG SEL., BEKASI, JAWA BARAT 17530 KAWASAN EJIP KAV 5 J', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290346', 'SAKURA 2', 'JL CITANDUY RAYA KAWASAN EJIP PLOT NO. 7H 2-3, CIKARANG SELATAN', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290347', 'SAKURA 3', 'JALAN MERANTI 1 BLOK L2 NO. 7 DELTA SILIKON 1', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290348', 'RS ADAM THOLIB / JASEN', 'JL TEUKU UMAR NO. 25

CIKARANG BARAT', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290349', 'PT.NIPPO', 'Jl. Inti II Blok C4 No.6-7 KAWASAN B11E (HYUNDAI), Cikarang Sel., Bekasi, Jawa Barat 17530', '71329900', 'F22', true);
INSERT INTO outlet VALUES ('713290352', 'KOP PT HI-LEX', 'JL TREMBESSI 1 BLOK F16 NO. 1

DELTA CILICON 1 DS CICAU , CIKARANG PUSAT', '71329900', 'F21', true);
INSERT INTO outlet VALUES ('713290367', 'KIRANA GEMALAPIK', 'JL. GEMLAPIK DEKAT SUNGAI NO. 101 PTGEMALAPIK', '71329900', 'F01', true);
INSERT INTO outlet VALUES ('713290368', 'PT. DAIHO', 'Jl. Industri Kawasan GIIC blok AB No.5         

 Kota Deltamas nagasari        

 Serang baru Cikarang', '71329900', 'F01', true);


--
-- TOC entry 1970 (class 0 OID 18482)
-- Dependencies: 176
-- Data for Name: product; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO product VALUES ('code', 'name ', 'sort ', 'brand', 'jenis', 'category', 'subca', 202.0000, false);
INSERT INTO product VALUES ('FG0001', 'ROTI TAWAR SPESIAL', 'RTS  ', 'Sari Roti', 'TAWAR', 'dasdasd', 'TAWAR', 12000.0000, false);
INSERT INTO product VALUES ('FG201003', 'SANDWICH COKLAT', 'SCK  ', 'Sari Roti', 'CAKE', 'Manis', 'MANIS', 4000.0000, false);
INSERT INTO product VALUES ('fg100000', 'ROTI TAWAR KUPAS', 'RKU  ', 'SARI ROTI', 'ROTI', 'TAWAR', 'tawar series', 12000.0000, true);
INSERT INTO product VALUES ('FG00012', 'ROTI TAWAR SPESIAL', 'RTS  ', 'SARI ROTI', 'MAKANAN', 'BREAD', 'TAWAR', 12000.0000, true);
INSERT INTO product VALUES ('FG101007', 'ROTI TAWAR GANDUM', 'RTG  ', 'SARI ROTI', 'BREAD', 'WHITE BREAD', 'TAWAR SERIES', 18000.0000, false);
INSERT INTO product VALUES ('FG101009', 'ROTI TAWAR MINISOFT', 'TAMS ', 'SARI ROTI', 'BREAD', 'WHITE BREAD', 'TAWAR SERIES', 12000.0000, false);
INSERT INTO product VALUES ('FG101017', 'ROTI TAWAR KUPAS', 'RKU  ', 'SARI ROTI', 'BREAD', 'WHITE BREAD', 'TAWAR SERIES', 14500.0000, false);
INSERT INTO product VALUES ('FG101025', 'SANDWICH BLUEBERRY', 'SAB  ', 'SARI ROTI', 'BREAD', 'WHITE BREAD', 'SANDWICH SERIES', 4000.0000, false);
INSERT INTO product VALUES ('FG101027', 'SANDWICH KRIM KEJU', 'SKJ  ', 'SARI ROTI', 'BREAD', 'WHITE BREAD', 'SANDWICH SERIES', 4000.0000, false);
INSERT INTO product VALUES ('FG101030', 'SANDWICH SARIKAYA MEDAN', 'SSM  ', 'SARI ROTI', 'BREAD', 'WHITE BREAD', 'SANDWICH SERIES', 4000.0000, false);
INSERT INTO product VALUES ('FG101039', 'ROTI JUMBO TAWAR KUPAS', 'RJKU ', 'SARI ROTI', 'BREAD', 'WHITE BREAD', 'TAWAR SERIES', 18000.0000, false);
INSERT INTO product VALUES ('FG201001', 'ISI COKLAT', 'ICK  ', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'BUN SERIES', 6000.0000, false);
INSERT INTO product VALUES ('FG201007', 'ROTI ISI PISANG COKELAT (72GR)', 'IPC72', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'BUN SERIES', 6500.0000, false);
INSERT INTO product VALUES ('FG201011', 'ROTI MINI ISI STROBERI', 'MIST ', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'BUN SERIES', 4000.0000, false);
INSERT INTO product VALUES ('FG201014', 'ROTI MINI ISI KEJU', 'MIKJ ', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'BUN SERIES', 4000.0000, false);
INSERT INTO product VALUES ('FG201020', 'ISI COKLAT KEJU', 'ICC  ', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'BUN SERIES', 6000.0000, false);
INSERT INTO product VALUES ('FG201022', 'ISI BEEF BARBEQUE', 'IBQ  ', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'BUN SERIES', 7500.0000, false);
INSERT INTO product VALUES ('FG203001', 'KRIM COKLAT', 'SRC  ', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'SANDROLL SERIES', 4500.0000, false);
INSERT INTO product VALUES ('FG203008', 'KRIM COKLAT VANILLA', 'SCV  ', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'SANDROLL SERIES', 4500.0000, false);
INSERT INTO product VALUES ('FG203016', 'ROTI ISI KRIM KAPUCINO', 'SRK  ', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'SANDROLL SERIES', 4500.0000, false);
INSERT INTO product VALUES ('FG204001', 'DORAYAKI ISI COKLAT', 'DIC  ', 'SARI CAKE', 'NON BREAD', 'CAKE', 'PANCAKE SERIES', 5000.0000, false);
INSERT INTO product VALUES ('FG204003', 'DORAYAKI SELAI SARIKAYA PANDAN', 'DIP  ', 'SARI ROTI', 'NON BREAD', 'CAKE', 'PANCAKE SERIES', 5000.0000, false);
INSERT INTO product VALUES ('FG206003', 'SOBEK COKLAT KEJU', 'TCC  ', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'TEAR SERIES', 15500.0000, false);
INSERT INTO product VALUES ('FG206005', 'SISIR MENTEGA', 'RSM  ', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'TEAR SERIES', 10000.0000, false);
INSERT INTO product VALUES ('FG206008', 'SOBEK COKLAT STRAWBERRY', 'TST  ', 'SARI ROTI', 'BREAD', 'SWEET BREAD', 'TEAR SERIES', 15000.0000, false);
INSERT INTO product VALUES ('FG801002', 'CHIFFON CAKE COKLAT', 'CCC  ', 'SARI ROTI', 'NON BREAD', 'CAKE', 'CHIFFON SERIES', 4000.0000, false);
INSERT INTO product VALUES ('FG801004', 'CHIFFON CAKE STRAWBERRY', 'CCS  ', 'SARI ROTI', 'NON BREAD', 'CAKE', 'CHIFFON SERIES', 4000.0000, false);
INSERT INTO product VALUES ('FG802003', 'KASTELLA ORIGINAL FAMILY', 'KAOF ', 'SARI ROTI', 'NON BREAD', 'CAKE', 'PANCAKE SERIES', 250000.0000, false);
INSERT INTO product VALUES ('FG803002', 'BAMKUHEN COKELAT', 'BKCK ', 'SARI CAKE', 'NON BREAD', 'CAKE', 'PANCAKE SERIES', 10000.0000, false);
INSERT INTO product VALUES ('FG803001', 'LAPIS BAMKUHEN ORIGINAL', 'BKOR ', 'SARI CAKE', 'NON BREAD', 'CAKE', 'PANCAKE SERIES', 10000.0000, false);


--
-- TOC entry 1967 (class 0 OID 18458)
-- Dependencies: 173
-- Data for Name: salesman; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 1968 (class 0 OID 18463)
-- Dependencies: 174
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 1857 (class 2606 OID 18541)
-- Name: df_items_detaiID; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY invoicedetail
    ADD CONSTRAINT "df_items_detaiID" PRIMARY KEY (itemcode, invoiceid);


--
-- TOC entry 1847 (class 2606 OID 18510)
-- Name: outlCode; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY outlet
    ADD CONSTRAINT "outlCode" PRIMARY KEY (outlcode);


--
-- TOC entry 1855 (class 2606 OID 18501)
-- Name: pk_invoiced; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY invoice
    ADD CONSTRAINT pk_invoiced PRIMARY KEY (invoiceid, nomorinvoice);


--
-- TOC entry 1853 (class 2606 OID 18486)
-- Name: pk_item; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY product
    ADD CONSTRAINT pk_item PRIMARY KEY (itemcode);


--
-- TOC entry 1849 (class 2606 OID 18462)
-- Name: pk_salesman; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY salesman
    ADD CONSTRAINT pk_salesman PRIMARY KEY (slsmcode);


--
-- TOC entry 1851 (class 2606 OID 18467)
-- Name: pk_user; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY users
    ADD CONSTRAINT pk_user PRIMARY KEY (userid, username);


--
-- TOC entry 1979 (class 0 OID 0)
-- Dependencies: 6
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2018-01-13 06:17:37

--
-- PostgreSQL database dump complete
--

