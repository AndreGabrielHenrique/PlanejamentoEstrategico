class Projeto:
    def __init__(self, nome, etapa):
        self.separador = '-' * 108
        self.nome = nome
        self.etapa = etapa


    def planejamento_estrategico(self):
        print(self.separador)
        print(f"\033Nome do projeto: {self.nome}\033")
        print(f"\033{self.etapa}\033")
        print(self.separador)


def inserir_nome():
    nome = input("Entre com o nome do projeto:")
    if not nome.strip() or len(nome) < 3:
        print(f"Nome em branco ou com menos de três caracteres.\n{separador}")
        return inserir_nome()
    else:
        return nome


def qual_etapa(nome):
    print(separador)
    print("Diga qual etapa do planejamento estratégico deseja detalhar (digite Análise do ambiente, Definição de Metas,\nFormulação de Estratégias ou Implementação e Acompanhamento):")
    opcao = input().strip().lower()
    if opcao == "análise do ambiente":
        print(separador)
        analise_ambiente()
    elif opcao == "definição de metas":
        print(separador)
        definicao_metas()
    elif opcao == "formulação de estratégias":
        print(separador)
        formulacao_estrategias()
    elif opcao == "implementação e acompanhamento":
        print(separador)
        implementacao_acompanhamento()
    else:
        print("Opção incorreta.")
        qual_etapa(nome)

        
def analise_ambiente():
    ambiente = input("Detalhe tudo que analisar do ambiente:")
    if not ambiente.strip() or len(ambiente) < 3:
        print(f"Em branco ou com menos de três caracteres.\n{separador}")
        analise_ambiente()
    projeto = Projeto(nome, ambiente)
    projeto.planejamento_estrategico()
    recomecar()
            

def definicao_metas():
    metas = input("Defina as metas almejadas para o projeto:")
    if not metas.strip() or len(metas) < 3:
        print(f"Em branco ou com menos de três caracteres.\n{separador}")
        definicao_metas()
    projeto = Projeto(nome, metas)
    projeto.planejamento_estrategico()
    recomecar()
    

def formulacao_estrategias():
    estrategias = input("Desenvolva suas estratégias e planos de ação para atingir suas metas:")
    if not estrategias.strip() or len(estrategias) < 3:
        print(f"Em branco ou com menos de três caracteres.\n{separador}")
        formulacao_estrategias()
    projeto = Projeto(nome, estrategias)
    projeto.planejamento_estrategico()
    recomecar()
    

def implementacao_acompanhamento():
    implementacao = input("Como irá implementar e monitorar o projeto?")
    if not implementacao.strip() or len(implementacao) < 3:
        print(f"Em branco ou com menos de três caracteres.\n{separador}")
        implementacao_acompanhamento()
    projeto = Projeto(nome, implementacao)
    projeto.planejamento_estrategico()
    recomecar()


def limpar_tela():
    input()
    print('\n'*50)


def recomecar():
    escolha = input("Deseja recomeçar?").strip().lower()
    if escolha == "sim":
        print(separador)
        limpar_tela()
        print(separador)
        nome = inserir_nome()
        qual_etapa(nome)
    else:
        print(separador)
        print("Obrigado, tenha um bom dia.")
        print(separador)
        from sys import exit
        exit()


if __name__ == "__main__":
    separador = '-' * 108
    print(separador)
    print("Gerenciador de Planejamento Estratégico")
    print(separador)
    nome = inserir_nome()
    qual_etapa(nome)