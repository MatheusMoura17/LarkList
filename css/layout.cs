Matheus


Pesquisar no Google Drive

Drive
.
Caminho da pasta
Meu Drive
Lark List
css
NOVO 
Pastas e visualizações
Meu Drive
Compartilhados comigo
Google Fotos
Recentes
Com estrela
Lixeira
3 GB de 15 GB usados
Fazer upgrade do armazenamento
.

Folha de estilos
layout.css
Folha de estilos
layout.css
Detalhes
Atividade
HÁ MUITO TEMPO

Vocêcriou e compartilhou um item em
Computador • 31 de dez de 2014
Pasta do Google Drive
css
Folha de estilos
layout.css
Pode visualizar
Qualquer pessoa
Nenhuma atividade registrada antes de 31 de dezembro de 2014
Instalar o Drive para PC
Todas as seleções foram removidas


@charset "utf-8";
/* CSS Document */
.logo{
	background-image:url(../imagens/logo.png);
	background-repeat:no-repeat;
	width:441px;
	height:69px;
	margin-bottom:20px;	
}
.search{
	color:#FFF;
	font-size:30px;
	z-index:2;
	background: -webkit-linear-gradient(rgb(228,45,39), rgb(192,24,29));  
  	background: -o-linear-gradient(rgb(228,45,39), rgb(192,24,29));  
  	background: -moz-linear-gradient(rgb(228,45,39), rgb(192,24,29));  
  	background: linear-gradient(rgb(228,45,39), rgb(192,24,29)); 
	position:fixed;
	width:475px;
	height:25px;
	right:0;
	bottom:35px;
	padding:10px;
	opacity:0.8;
}
#ss{
	position:float;
	float:left;	
}
.bt{
	background-image:url(../imagens/lupa.png);
	background-repeat:no-repeat;
	background-size:20px 20px;
	height:20px;
	width:20px;
	margin-left:-3px;
	margin-right:3px;
	margin-top:-5px;
}
body{
  margin:0;
  background-color:#000000;
}
iframe{
	width:100%;
	height:100%;
	position:absolute;
	border:0;
	outline:0;
	z-index:0;
}
.main{
	z-index:3;
	position:absolute;
	width:100%;
	height:100%;
 	background: -webkit-linear-gradient(rgb(228,45,39),  rgb(150,40,40));  
  	background: -o-linear-gradient(rgb(228,45,39), rgb(150,40,40));   
  	background: -moz-linear-gradient(rgb(228,45,39), rgb(150,40,40)); 
  	background: linear-gradient(rgb(228,45,39), rgb(150,40,40)); 	
}
.bt_search, .bt_search2{
	float:left;
	background-image:url(../imagens/bt_search.png);
	width:35px;
	height:26px;
	background-repeat:no-repeat;
	background-size:35px 26px;
}
.text{
	text-align:justify;
	margin-top: 60px;	
}

.center{
	color:#FFF;
	opacity:1;
	width: 441px;
	margin:0 auto;
  	animation: in 1.3s;
	-webkit-animation: in 1.3s;
	margin-top:300px;
}

input:focus{
	border:none;
	outline:0;
}
@-webkit-keyframes hide{
	0%{right:0;}
	100%{right:-460px;}
}
@-webkit-keyframes show{
	0%{right:-460px;}
	100%{right:0;}
}

@-webkit-keyframes in{
	0%{opacity:0;margin-top:28%;}
	100%{opacity:1;}
}

@keyframes in{
	0%{opacity:0;margin-top:30%;}
	100%{opacity:1;}
}

@keyframes out{
	0%{margin-top:0;}
	100%{margin-top:-100%;}
}
@-webkit-keyframes out{
	0%{margin-top:0;}
	100%{margin-top:-100%;}
}
a{
	color:#CCCCCC;
	text-decoration:none;	
}
.frame{
	position:absolute;
	width:100%;
	height:100%;
	background-image:url(../imagens/carregando.gif);
	background-size: 500px 500px;
	background-repeat:no-repeat;
	background-position:center;	
}

input{
	outline:0;
	border-radius: 5px;
	-webkit-border-radius: 5px;
	-moz-border-radius: 5px;
	border:none;
	clear:both;
	float:left;
	margin-right:10px;
	width:385px;
	padding:5px;
}
