function mostraAlerta(){

    alert('Implementação da função em Andamento!');

}

function Circlle(el){

    $(el).circleProgress({fill: {color:'#ff5c5c'}})
    .on('circle-animation-progress', function(event, progress, stepValue){

        $(this).find('strong').text(String(stepValue.toFixed(2)).substr(2)+'%');

    });
};

Circlle('.porcentagem');