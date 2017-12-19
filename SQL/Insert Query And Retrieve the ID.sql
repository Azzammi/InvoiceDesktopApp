INSERT INTO invoice(
            nomorinvoice, duedate, outletcode, subtotal, ppn, 
            total, issueddate, isppn, nomorpo, periode, pengguna, idpayment, 
            ispayed)
    VALUES ( 'jjjkk', '2017-08-11', ' ', 133330, 9.2, 
            9044412, '2017-08-11', true, 'FK0021', '00', 'admin', ' ', 
            true);
    SELECT currval('invoiced_seq');
