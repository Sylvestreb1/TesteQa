#language: pt-br

Funcionalidade: TesteEveris Validar os valores no carrinho

Escrever um cenário de testes que valida os valores no carrinho de um produto no
website: My Store (automationpractice.com) (Se a automação for feito utilizando a
linguagem gherkin, não é necessário fazer esse exercício)


@"Caso1"
Cenário: Validar os valores no carrinho
	Dado que escolhi um produto
	Quando cliquei no botão adicionar no carrinho
	E cliquei no botão do carrinho
	Então validei o valor Shipping e valor Total

@"Caso2"
Cenário: Validar o total da compra
	Dado que escolhi um produto
	Quando cliquei no botão adicionar no carrinho
	E cliquei no botão do carrinho
	Então validei o total da compra

