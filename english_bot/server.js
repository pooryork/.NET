const express = require('express');
const ejs = require('ejs');
let bodyParser = require("body-parser");
let urlencodedParser = bodyParser.urlencoded({ extended: false });

let app = express();

app.set('view engine', 'ejs');

app.use(__dirname + './static', express.static('static'));

app.get('/', (req,res) => {
    res.writeHead(302, {
        'Location': '/main'
    });
    res.end();
});

app.get('/main', function(req, res) {
    res.render('main', {typeAuth:'noLogin', type_content:'mainInfo'});
});

app.get('/learn', function(req, res) {
    res.render('main', {typeAuth:'noLogin', type_content:'learn'});
});

app.get('/about', function(req, res) {
    res.render('main', {typeAuth:'noLogin', type_content:'about'});
});

app.get('/train', function(req, res) {
    res.render('main', {typeAuth:'noLogin', type_content:'train'});
});

app.get('/admin', function(req, res) {
    res.render('main', {typeAuth:'noLogin', type_content:'admin'});
});

app.post('/register', urlencodedParser, function (req, res) {

    let data = req.body;

    console.log(data.login);    

});

app.listen(3000);

