
function changeColor(color){
    document.body.style.background = color;
}

function hideText(funcao){
    document.getElementById("paragrafo").style.display = funcao;
}

function habilitaBotao(){
    var box1 = document.getElementById("box1");
    var box2 = document.getElementById("box2");
    var box3 = document.getElementById("box3");
    var box4 = document.getElementById("box4");
    
    if(box1.checked && box2.checked){
        box3.disabled = false;
        box4.disabled = false;
    }else{
        box3.checked = false;
        box3.disabled = true;
        box4.checked = false;
        box4.disabled = true;
    }
}

function changeFont(funcao){
    document.getElementById("paragrafo2").style.color = funcao;
}
function changeBack(funcao){
    document.getElementById("paragrafo2").style.background = funcao;
}
function sizeFont(funcao){
    if(funcao == "up"){
        document.getElementById("paragrafo2").style.fontSize = "24px";
    }else{
        document.getElementById("paragrafo2").style.fontSize = "14px";
    }
}
function fontType(funcao){
    document.getElementById("paragrafo2").style.textTransform = funcao;
}

function verify(senha1, senha2){
    var senha1 = document.getElementById("senha1").value;
    var senha2 = document.getElementById("senha2").value;

    if (senha1 != senha2){
    	alert('As senhas não coincidem');
    }else if(senha1.length < 6 || senha2.length < 6 || senha1.length > 10 || senha2.length > 10){
        alert('A senha deve ser de no mínimo 6 e no máximo 10 caracteres')
    }else{
        alert("Formulário enviado")
    }
}

function formulario(){
    var fisica = document.getElementById("fisica");
    var juridica = document.getElementById("juridica");
    var data = document.getElementById("data");
    if(fisica.checked){
        cnpj.value="";
        cpf.disabled = false;
        cnpj.disabled = true;
        data.disabled = false;
    }else if (juridica.checked){
        cpf.value = "";
        data.value = "";
        cnpj.disabled = false;
        cpf.disabled = true;
        data.disabled = true;
    }
}