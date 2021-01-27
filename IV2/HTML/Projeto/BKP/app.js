document.getElementById('click').onclick = () => {
    alert ('voce clicou no botao')
}


setTimeout (()=>{alert('BEM - VINDO ao MyBank')},3000)

setTimeout(()=>{
    document.getElementById('caixaTexto').style.visibility = 'visible';
},5000);

caixaTexto.onclick = ()=> {
    document.getElementById('caixaTexto').style.visibility = 'hidden';
};
