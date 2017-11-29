var express = require('express');
var router = express.Router();

/* GET game1 page. */
router.get('/game1', function(req, res, next) {
    res.render('game1', { title: 'GameKit' });
});

module.exports = router;