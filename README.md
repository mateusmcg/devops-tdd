# devops-tdd

## Respostas Parte 2

1. Que funcionalidades específicas esta ferramenta pode apoiar na esfera da qualidade contínua de código?
  * Inspeção contínua: Funcionalidades que visam dar uma visão geral da qualidade contínua do projeto, informando os bug e        vulnerabilidades encontrados, vazão de novos códigos e melhorias. Informa se uma nova versão do projeto pode ou não ser colocada em produção. Análise da ramificação para que apenas códigos limpos e aprovados sejam mesclados com o principal. Informa todos os detalhes dos problemas encontrados e registrados, facilitando a localização e resolução dos problemas encontrados. 
  * Detectar Problemas Complicados: Verifica possíveis erros nos códigos, trechos de códigos complexos, apontando os locais dos problemas detectados. Ferramentas que verificam as possíveis vulnerabilidades do código, códigos duplicados e descobertos por testes unitários. Explora todos os caminhos de execução para detectar os bugs mais complexos. 
  * Multi idiomas: O sonar trabalha com várias das principais linguagens de programação, ele detecta automaticamente a linguagem de programação que está rodando no momento e  aciona os analisadores correspondentes. 
  * Integração DevOps: Integração com ferramentas que auxiliam no DevOps. 
  * Centralizar a qualidade: Todos os projetos em um só lugar, permitindo o dimensionamento da qualidade do código. 
2. Como é a relação desta ferramenta com processos DevOps?
  * Faz integração com ferramentas de build para fornecer resultados precisos de análise, as ferramentas de builds que integram com o sonar são: MSBuild, Maven, Gradle, Ant e Makefiles. Permite agendar a execução de uma análise de todos os mecanismos  de CI. Realizar notificações de aprovação e reprovação após uma análise ser feita, possui um mecanismo chamado webhook, que permite fazer as notificações em qualquer sistema externo. Pode ser integrado com os canais de entrega, garantindo que apenas os artefatos que passaram na qualidade, possam ser liberados  e implantados na produção. 
