function mostraAlerta() {

    alert('Implementação da função em Andamento!');

}

function Circlle(el) {

    $(el).circleProgress({ fill: { color: '#ff5c5c' } })
        .on('circle-animation-progress', function (event, progress, stepValue) {

            $(this).find('strong').text(String(stepValue.toFixed(2)).substr(2) + '%');

        });
};

Circlle('.porcentagem');

function carrega() {

    Circlle('.porcentagem');
    document.getElementById('final').onmouseover = null;

};

// function isScrolledIntoView(elem){
//     var docViewTop = $(window).scrollTop();
//     var docViewBottom = docViewTop + $(window).height();

//     var elemTop = $(elem).offset().top;
//     var elemBottom = elemTop + $(elem).height();

//     return ((elemBottom <= docViewBottom) && (elemTop >= docViewTop));
// }

// $(window).on('scroll', function(){
//   if(isScrolledIntoView('.row')){
//     Circlle('.porcentagem');
    
//   }
//   else{
//     $('.row').removeClass('bounceIn');
//   }
// });