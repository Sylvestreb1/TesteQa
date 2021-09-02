#language: pt-br
Funcionalidade: AUT_2435_RETAGUARDA_8.1.6.2
	Ao efetuar um lançamento no apagar e informo os inicial dia e mês e clico no botão enter o sistema esta preenchendo o ano de 1999.

@"Quando_informo_a_data_traz_o_ano_1999"
Cenário: Quando_informo_a_data_traz_o_ano_1999
	Dado que informei o usuario
	Quando informei a senha
	E cliquei no botão OK
	Então deve entrar na tela home
	E cliquei no financeiro/ apagar
	E clico no botão lançamento
	E deve mostrar a tela de lançamento
	E informei a data no campo Emissão
	E validei a informação  no campo Emissão
