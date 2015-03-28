using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ORIONNFE.CLASSE
{
    class xml
    {
        public void GerarArquivoXml()
        {
            try
            {
                UTF8Encoding _utf8 = new UTF8Encoding();
                XmlTextWriter _xml = new XmlTextWriter("D:\\myXmFile.xml", _utf8);
                _xml.WriteStartDocument();
                #region enviNFe
                _xml.WriteStartElement("enviNFe");
                _xml.WriteStartAttribute("xmlns");
                _xml.WriteString("http://www.portalfiscal.inf.br/nfe");
                _xml.WriteEndAttribute();
                _xml.WriteStartAttribute("versao");// escrevendo no atributo
                _xml.WriteString("2.00");
                _xml.WriteEndAttribute();
                _xml.WriteStartAttribute("xmlns:xsi");
                _xml.WriteString("http://www.w3.org/2001/XMLSchema-instance");// escrevendo no atributo
                _xml.WriteEndAttribute();
                _xml.WriteStartAttribute("xsi:schemaLocation");
                _xml.WriteString("http://www.portalfiscal.inf.br/nfe enviNFe_v2.00.xsd");// escrevendo no atributo
                _xml.WriteEndAttribute();

                _xml.WriteStartElement("idLote");//Tag Lote, seguencial controlando no sistema.
                _xml.WriteString("000000099");// numero do lote
                _xml.WriteEndElement();
                #region NFe
                _xml.WriteStartElement("Nfe", "http://www.portalfiscal.inf.br/nfe");// TAG raiz da NF-e, Nó com tipo de
                #region infNFe
                _xml.WriteStartElement("infNFe");//Grupo que contém as informações da NF-e;

                _xml.WriteStartAttribute("Id");// informar a chave de acesso da
                //NF-e precedida do literal ‘NFe’,
                //acrescentada a validação do
                //formato (v2.0).
                _xml.WriteString("Nfe" + "35090448124770000172550010000000020000000820");
                _xml.WriteEndAttribute();

                _xml.WriteStartAttribute("versao");////Versão do leiaute (v2.0),Atributos do Nó
                _xml.WriteString("2.00");//vesao da nfe.
                _xml.WriteEndAttribute();

                #region ide
                _xml.WriteStartElement("ide");//ide (inserida como filha na tag infNFe)
                _xml.WriteStartElement("cUF");//Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE de código de unidades da federação (Anexo IV - Tabela de UF, Município e País).
                _xml.WriteString("000001");// Código da Uf, tam. 2
                _xml.WriteEndElement();

                _xml.WriteStartElement("cNF");//Código numérico que compõe a Chave de Acesso. Número aleatório gerado pelo emitente para cada NF-e para evitar acessos indevidos da NF-e.(v2.0)
                _xml.WriteString("000000027");// Código da Nf, tam. 8
                _xml.WriteEndElement();

                _xml.WriteStartElement("natOp");//Descrição da Natureza da Operação
                _xml.WriteString("VENDAS DE PRODUCAO DO ESTABELECIMENTO");// Tam. 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("indPag");//Indicador forma de pagamento; 0 – pagamento à vista;1 – pagamento à prazo;2 - outros.
                _xml.WriteString("1");// tam. 1
                _xml.WriteEndElement();

                _xml.WriteStartElement("mod");//Código do Modelo do Documento Fiscal
                _xml.WriteString("55");// tam. 2; Utilizar o código 55 para identificação da NF-e, emitida em substituição ao modelo 1 ou 1A.
                _xml.WriteEndElement();

                _xml.WriteStartElement("serie");//Série do Documento Fiscal
                _xml.WriteString("1");// Tam 1-3
                _xml.WriteEndElement();

                _xml.WriteStartElement("nNF");//Número do Documento Fiscal
                _xml.WriteString("11");// Tam. 1 - 9
                _xml.WriteEndElement();

                _xml.WriteStartElement("dEmi");//Data de emissão do Documento Fiscal
                _xml.WriteString("2009-05-18");// Formato “AAAA-MM-DD”
                _xml.WriteEndElement();

                _xml.WriteStartElement("dSaiEnt");//Data de Saída ou da Entrada da Mercadoria/Produto
                _xml.WriteString("2009-05-18");// Formato “AAAA-MM-DD”
                _xml.WriteEndElement();

                //ocorrencia 0-1
                _xml.WriteStartElement("hSaiEnt");//Hora de Saída ou da Entrada da Mercadoria/Produto
                _xml.WriteString("1");// Formato “HH:MM:SS” (v.2.0)
                _xml.WriteEndElement();

                _xml.WriteStartElement("tpNF");//Tipo de Operação
                _xml.WriteString("1");// 0-entrada / 1-saída, tam. 1
                _xml.WriteEndElement();

                _xml.WriteStartElement("cMunFG");//Código do Município de Ocorrência do Fato Gerador
                _xml.WriteString("5220280");// tam. 7
                _xml.WriteEndElement();

                //ide (inserida como filha na tag infNFe)//Grupo com as informações das NF/NF-e /NF de produtor/Cupom Fiscal referenciadas.
                //Esta informação será utilizada nas hipóteses previstas na legislação. (Ex.: Devolução de Mercadorias, Substituição de NF cancelada, Complementação de NF, etc.). (v.2.0)
                //Ocorrencia 0-N B12a
                #region NFref
                _xml.WriteStartElement("NFref");

                _xml.WriteStartElement("refNFe");//Chave de acesso da NF-e referenciada
                _xml.WriteString("1");// Tam 44, Utilizar esta TAG para referenciar uma Nota Fiscal Eletrônica emitida anteriormente, vinculada a NF-e atual.
                _xml.WriteEndElement();

                #region refNF
                _xml.WriteStartElement("refNF");//Grupo de informação da NF modelo 1/1A referenciada

                _xml.WriteStartElement("cUF");//Código da UF do emitente do Documento Fiscal
                _xml.WriteString("1");// tam. 2
                _xml.WriteEndElement();

                _xml.WriteStartElement("AAMM");//Ano e Mês de emissão da NFe
                _xml.WriteString("1");// tam. 4
                _xml.WriteEndElement();

                _xml.WriteStartElement("CNPJ");//CNPJ do emitente
                _xml.WriteString("1");// tam. 14
                _xml.WriteEndElement();

                _xml.WriteStartElement("mod");//Modelo do Documento Fiscal
                _xml.WriteString("1");// tam. 2
                _xml.WriteEndElement();

                _xml.WriteStartElement("serie");//Série do Documento Fiscal
                _xml.WriteString("1");// tam. 1-3
                _xml.WriteEndElement();

                _xml.WriteStartElement("nNF");//Número do Documento Fiscal
                _xml.WriteString("1");// tam. 1-9
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion
                //ou
                #region refNFP
                _xml.WriteStartElement("refNFP");//Grupo de informação da NF modelo 1/1A referenciada

                //Grupo de informações da NF de produtor rural referenciada
                _xml.WriteStartElement("cUF");//Código da UF do emitente do Documento Fiscal
                _xml.WriteString("1");// tam. 2
                _xml.WriteEndElement();

                _xml.WriteStartElement("AAMM");//Ano e Mês de emissão da NFe
                _xml.WriteString("1");// tam. 4
                _xml.WriteEndElement();

                _xml.WriteStartElement("CNPJ");//Informar o CNPJ do emitente da NF de produtor (v2.0)
                _xml.WriteString("1");// tam. 14
                _xml.WriteEndElement();

                _xml.WriteStartElement("CPF");//Informar o CPF do emitente da NF de produtor (v2.0)
                _xml.WriteString("1");// tam. 11
                _xml.WriteEndElement();

                _xml.WriteStartElement("IE");//Informar a IE do emitente da NF de Produtor (v2.0)
                _xml.WriteString("1");// tam. 1-14
                _xml.WriteEndElement();

                _xml.WriteStartElement("mod");//Modelo do Documento Fiscal
                _xml.WriteString("1");// tam. 2
                _xml.WriteEndElement();

                _xml.WriteStartElement("serie");//Série do Documento Fiscal
                _xml.WriteString("1");// tam. 1-3
                _xml.WriteEndElement();

                _xml.WriteStartElement("nNF");//Número do Documento Fiscal
                _xml.WriteString("1");// tam. 1-9
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion

                _xml.WriteStartElement("refCTe");//Chave de acesso do CT-e referenciada
                _xml.WriteString("1");// tam. 44
                _xml.WriteEndElement();

                #region refECF
                //Informações do Cupom Fiscal referenciado, vinculado à NF-e (v2.0).
                _xml.WriteStartElement("refECF");

                _xml.WriteStartElement("mod");//Preencher com "2B", quando se tratar de Cupom Fiscal emitido
                //por máquina registradora (não ECF), com "2C", quando se tratar de Cupom Fiscal PDV, ou "2D",
                //quando se tratar de Cupom Fiscal (emitido por ECF) (v2.0).
                _xml.WriteString("1");// tam. 2
                _xml.WriteEndElement();

                _xml.WriteStartElement("nECF");//Número de ordem seqüencial do ECF
                _xml.WriteString("1");// tam. 3
                _xml.WriteEndElement();

                _xml.WriteStartElement("nCOO");//Número do Contador de Ordem de Operação - COO
                _xml.WriteString("1");// tam. 6
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion

                _xml.WriteEndElement();

                #endregion

                _xml.WriteStartElement("tpImp");//Formato de Impressão do DANFE
                _xml.WriteString("1");//1-Retrato/ 2-Paisagem
                _xml.WriteEndElement();

                _xml.WriteStartElement("tpEmis");//Tipo de Emissão da NF-e (normal, contingencia, ver manual)
                _xml.WriteString("1");// tam. 1
                _xml.WriteEndElement();

                _xml.WriteStartElement("cDV");//Dígito Verificador da Chave de Acesso da NF-e
                _xml.WriteString("4");// tam. 1
                _xml.WriteEndElement();

                _xml.WriteStartElement("tpAmb");//Tipo de ambiente,1-Produção/ 2-Homologação
                _xml.WriteString("2");// Tam 1
                _xml.WriteEndElement();

                _xml.WriteStartElement("finNFe");//Finalidade de emissão da NFe,1- NF-e normal/ 2-NF-e complementar / 3 – NF-e de ajuste
                _xml.WriteString("1");// Finalidade da Nfe
                _xml.WriteEndElement();

                _xml.WriteStartElement("procEmi");//Processo de emissão da NF-e
                _xml.WriteString("1");// Tam 1
                _xml.WriteEndElement();

                _xml.WriteStartElement("verProc");//Versão do Processo de emissão da NF-e
                _xml.WriteString("1");// tam. 1-20
                _xml.WriteEndElement();

                _xml.WriteEndElement();//ide
                //fim ide
                #endregion
                //omitido tags dhCont, xJust
                #region emit
                _xml.WriteStartElement("emit");//ide

                _xml.WriteStartElement("CNPJ");// CNPJ Emitente
                _xml.WriteString("04140021000163");// tam 14
                _xml.WriteEndElement();
                //or
                _xml.WriteStartElement("CPF");//CPF Emitente
                _xml.WriteString("04140021000163");// Tam. 11
                _xml.WriteEndElement();

                _xml.WriteStartElement("xNome");//Razão Social ou Nome do emitente
                _xml.WriteString("ACCESS");// tam. 2-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("xFant");//Nome fantasia
                _xml.WriteString("ACCESS");// tam. 1-60
                _xml.WriteEndElement();
                #region enderEmit
                _xml.WriteStartElement("enderEmit");//Tag codigo Uf

                _xml.WriteStartElement("xLgr");//Logradouro
                _xml.WriteString("RUA JOAO DE CARVALHO");//tam. 2-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("nro");//Número
                _xml.WriteString("15");// 1-60
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("xCpl");//Número
                _xml.WriteString("15");// 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("xBairro");//Bairro
                _xml.WriteString("SE");// tam. 2-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("cMun");//Código do município
                _xml.WriteString("5220280");// 1
                _xml.WriteEndElement();

                _xml.WriteStartElement("xMun");//Nome do município
                _xml.WriteString("SAO PATRICIO");// tam. 2-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("UF");//Sigla da UF
                _xml.WriteString("SP");// tam. 2
                _xml.WriteEndElement();

                _xml.WriteStartElement("CEP");//Código do CEP, Informar os zeros não significativos.
                _xml.WriteString("SP");// tam. 8
                _xml.WriteEndElement();

                _xml.WriteStartElement("cPais");//Código do País
                _xml.WriteString("1058");// tam. 4 1058 - Brasil
                _xml.WriteEndElement();

                _xml.WriteStartElement("xPais");//Nome do País
                _xml.WriteString("Brasil");// tam. 1-60; Brasil ou BRASIL
                _xml.WriteEndElement();

                _xml.WriteStartElement("fone");//Telefone
                _xml.WriteString("33414646");// tam. 6-14 - Preencher com o Código DDD + número do telefone.
                //Nas operações com exterior é permitido informar o código do país + código da localidade + número do telefone (v.2.0)
                _xml.WriteEndElement();
                _xml.WriteEndElement();//enderEmit
                #endregion

                _xml.WriteStartElement("IE");//IE
                _xml.WriteString("2254545");// tam. 0-14
                _xml.WriteEndElement();
                //Ocorrencia 0-1
                _xml.WriteStartElement("IEST");//IE do Substituto Tributário
                _xml.WriteString("2254545");// tam. 2-14
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("IM");//Inscrição Municipal
                _xml.WriteString("2254545");// tam. 1-15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("CNAE");//CNAE fiscal
                _xml.WriteString("2254545");// tam. 7
                _xml.WriteEndElement();

                _xml.WriteStartElement("CRT");//Código de Regime Tributário
                //Este campo será obrigatoriamente preenchido com:
                //1 – Simples Nacional;
                //2 – Simples Nacional – excesso de sublimite de receita bruta;
                //3 – Regime Normal. (v2.0).
                _xml.WriteString("2");// Tam. 1
                _xml.WriteEndElement();
                _xml.WriteEndElement();//emit
                #endregion
                //omitida tags avulsa e filhos
                #region dest
                _xml.WriteStartElement("dest");//dest

                _xml.WriteStartElement("CNPJ");//CNPJ do destinatário
                _xml.WriteString("13955471000103");// tam. 0-14
                _xml.WriteEndElement();
                //or
                _xml.WriteStartElement("CPF");//CPF do destinatário
                _xml.WriteString("13955471000103");// tam. 11
                _xml.WriteEndElement();

                _xml.WriteStartElement("xNome");//Razão Social ou nome do destinatário
                _xml.WriteString("JOSE FIRMINO e CIA LTDA");// tam 2-60
                _xml.WriteEndElement();
                #region enderDest
                _xml.WriteStartElement("enderDest");//enderDest

                _xml.WriteStartElement("xLgr");//Logradouro
                _xml.WriteString("RUA JOAO DE CARVALHO");// tam. 2-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("nro");//Número
                _xml.WriteString("10");// 1-60
                _xml.WriteEndElement();
                //Ocorrencia 0-1
                _xml.WriteStartElement("xCpl");//Complemento
                _xml.WriteString("SE");// tam. 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("xBairro");//Bairro
                _xml.WriteString("SE");//tam 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("cMun");//Código do município
                _xml.WriteString("3500303");//tam 7
                _xml.WriteEndElement();

                _xml.WriteStartElement("xMun");//Nome do município
                _xml.WriteString("AGUAI");//tam 2-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("UF");//Sigla da UF
                _xml.WriteString("SP");// tam. 2
                _xml.WriteEndElement();

                _xml.WriteStartElement("CEP");//Código do CEP, Informar os zeros não significativos.
                _xml.WriteString("01512030");// tam. 8
                _xml.WriteEndElement();

                _xml.WriteStartElement("cPais");//Código do País
                _xml.WriteString("1058");// tam 2-4
                _xml.WriteEndElement();

                _xml.WriteStartElement("xPais");//Nome do País
                _xml.WriteString("Brasil");// tam. 2-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("fone");//Telefone
                _xml.WriteString("33414646");//6-14
                _xml.WriteEndElement();

                _xml.WriteEndElement();//enderDest
                #endregion

                _xml.WriteStartElement("IE");//IE
                _xml.WriteString("03542907");// tam 0,2-14
                _xml.WriteEndElement();
                //omitido ISUF
                _xml.WriteStartElement("email");//email - Informar o e-mail do destinatário.
                _xml.WriteString("03542907");// tam 1-60
                _xml.WriteEndElement();

                _xml.WriteEndElement();//dest
                #endregion
                //Omitida tags retirada e filhos
                #region entrega
                _xml.WriteStartElement("entrega");//Tag codigo Uf

                _xml.WriteStartElement("CNPJ");//Informar o CNPJ ou o CPF,preenchendo os zeros não significativos. (v2.0)
                _xml.WriteString("13955471000103");// tam. 0-14
                _xml.WriteEndElement();
                //or
                _xml.WriteStartElement("CPF");//Informar o CNPJ ou o CPF,preenchendo os zeros não significativos. (v2.0)
                _xml.WriteString("13955471000103");// tam. 11
                _xml.WriteEndElement();

                _xml.WriteStartElement("xLgr");//Logradouro
                _xml.WriteString("RUA JOAO DE CARVALHO");// tam. 2-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("nro");//Número
                _xml.WriteString("10");// tam. 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("xCpl");//Complemento
                _xml.WriteString("10");// tam. 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("xBairro");//Bairro
                _xml.WriteString("SE");// tam. 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("cMun");//Código do município
                _xml.WriteString("3500303");//tam 7
                _xml.WriteEndElement();

                _xml.WriteStartElement("xMun");//Nome do município
                _xml.WriteString("Aguai");// tam 2-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("UF");//Sigla da UF
                _xml.WriteString("SP");// tam 2
                _xml.WriteEndElement();

                _xml.WriteEndElement();//entrega
                #endregion

                #region det
                int incrementoProd = 1;
                for (int i = 1; i <= 2; i++)//Itens da Nota
                {
                    _xml.WriteStartElement("det");//Grupo do detalhamento de Produtos e Serviços da NF-e
                    _xml.WriteStartAttribute("nItem");//Número do item (1-990)
                    _xml.WriteString(incrementoProd.ToString());
                    _xml.WriteEndAttribute();// finalizando o atributo
                    #region prod
                    _xml.WriteStartElement("prod");//TAG de grupo do detalhamento de Produtos e Serviços da NF-e

                    _xml.WriteStartElement("cProd");//Código do produto ou serviço
                    _xml.WriteString("2");// tam 1-60
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("cEAN");//GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras
                    _xml.WriteString("2");// tam 0,8,12,13,14
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("xProd");//Descrição do produto ou serviço
                    _xml.WriteString("TELHA COMERCIAL ROMANA VIDRO");// tam 1-120
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("NCM");//Código NCM com 8 dígitos ou 2 dígitos (gênero)
                    _xml.WriteString("10111212");// tam 2,8
                    _xml.WriteEndElement();
                    //omitida tag EX_TIPI
                    _xml.WriteStartElement("CFOP");//Código Fiscal de Operações e Prestações
                    _xml.WriteString("5101");// tam 4
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("uCom");//Unidade Comercial
                    _xml.WriteString("CX");// tam 1-6
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("qCom");//Quantidade Comercial
                    _xml.WriteString("200.0000");//tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vUnCom");//Valor Unitário de Comercialização
                    _xml.WriteString("2000000");//tam 21
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vProd");//Valor Total Bruto dos Produtos ou Serviços
                    _xml.WriteString("863.90");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("cEANTrib");//GTIN (Global Trade Item Number) da unidade tributável, antigo código EAN ou código de barras
                    _xml.WriteString("");// tam 0,8,12,13,14
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("uTrib");//Unidade Tributável
                    _xml.WriteString("CX");// tam 1-6
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("qTrib");//Quantidade Tributável
                    _xml.WriteString("200.0000");//tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vUnTrib");//Valor Unitário de tributação
                    _xml.WriteString("4.3195");// tam 21
                    _xml.WriteEndElement();
                    //ocorrencia 0-1
                    _xml.WriteStartElement("vFrete");//Valor Total do Frete
                    _xml.WriteString("4.3195");// tam 15
                    _xml.WriteEndElement();
                    //ocorrencia 0-1
                    _xml.WriteStartElement("vSeg");//Valor Total do Seguro
                    _xml.WriteString("4.3195");// tam 15
                    _xml.WriteEndElement();
                    //ocorrencia 0-1
                    _xml.WriteStartElement("vDesc");//Valor do Desconto
                    _xml.WriteString("4.3195");// tam 15
                    _xml.WriteEndElement();
                    //ocorrencia 0-1
                    _xml.WriteStartElement("vOutro");//Outras despesas acessórias
                    _xml.WriteString("4.3195");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("indTot");//Indica se valor do Item (vProd) entra no valor total da NF-e (vProd)
                    _xml.WriteString("4.3195");// Este campo deverá ser preenchido com:
                    //0 – o valor do item (vProd) não compõe o valor total da NF-e(vProd)
                    //1 – o valor do item (vProd)compõe o valor total da NF-e(vProd) (v2.0)
                    _xml.WriteEndElement();

                    _xml.WriteEndElement();//fim prod
                    #endregion

                    #region imposto
                    _xml.WriteStartElement("imposto");//Grupo de Tributos incidentes no Produto ou Serviço
                    #region ICMS
                    _xml.WriteStartElement("ICMS");//Grupo do ICMS da Operação própria e ST

                    #region ICMS_ValComum
                    _xml.WriteStartElement("ICMS" + "ColocarqualTipodoICMS");//Grupo do ICMS da Operação própria e ST

                    //para o caso ICMS00,10,20,30,40,51,90,Part,ST,101,102,201,202,500,900
                    _xml.WriteStartElement("orig");//Origem da mercadoria
                    _xml.WriteString("4");// tam 1
                    _xml.WriteEndElement();

                    //para o caso de ICMS101,102,201,202,500,900
                    _xml.WriteStartElement("CSOSN");//Código de Situação da Operação – Simples Nacional
                    _xml.WriteString("4");// tam 3
                    _xml.WriteEndElement();

                    //para o caso ICMS00,10,20,30,40,51,90,Part,ST
                    _xml.WriteStartElement("CST");//Tributação do ICMS = 00 – Tributada integralmente
                    _xml.WriteString("00");// tam 2
                    _xml.WriteEndElement();

                    //para o caso ICMS60,ST,500
                    #region ICMS60_ST_500
                    _xml.WriteStartElement("vBCSTRet");//Valor da BC do ICMS ST retido
                    _xml.WriteString("4");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vICMSSTRet");//Valor do ICMS ST retido
                    _xml.WriteString("00");// tam 15
                    _xml.WriteEndElement();
                    #endregion

                    //para o caso ICMSST
                    #region ICMSST
                    _xml.WriteStartElement("vBCSTDest");//Valor da BC do ICMS ST da UF destino
                    _xml.WriteString("4");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vICMSSTDest");//Valor do ICMS ST da UF destino
                    _xml.WriteString("00");// tam 15
                    _xml.WriteEndElement();
                    #endregion

                    //para o caso ICMS00,10,20,51,70,90,Part,900
                    _xml.WriteStartElement("modBC");//Modalidade de determinação da BC do ICMS
                    _xml.WriteString("1");// tam 1
                    _xml.WriteEndElement();
                    //para o caso de ICMS20,51,70,90(obs: no manual vem depois do vBC)
                    #region ICMS20_ICMS51
                    _xml.WriteStartElement("pRedBC");//Percentual da Redução de BC
                    _xml.WriteString("43195");// tam 5
                    _xml.WriteEndElement();
                    #endregion

                    //para o caso ICMS00,10,20,51,70,90,Part,900
                    _xml.WriteStartElement("vBC");//Valor da BC do ICMS
                    _xml.WriteString("43195");// tam 15
                    _xml.WriteEndElement();

                    //para o caso de ICMS90,Part,900
                    #region ICMS90_Part_900
                    _xml.WriteStartElement("pRedBC");//Percentual da Redução de BC
                    _xml.WriteString("43195");// tam 5
                    _xml.WriteEndElement();
                    #endregion

                    //para o caso ICMS00,10,20,40,51,70,90,Part,900
                    _xml.WriteStartElement("pICMS");//Alíquota do imposto
                    _xml.WriteString("4.30");// tam 5
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vICMS");//Valor do ICMS
                    _xml.WriteString("4.30");// tam 5
                    _xml.WriteEndElement();

                    //para o caso de ICMS10,30,70,90,Part,201,202,900
                    #region ICMS10_30_70_90_Part_201_202_900
                    _xml.WriteStartElement("modBCST");//Modalidade de determinação da BC do ICMS ST
                    _xml.WriteString("4");// tam 1
                    _xml.WriteEndElement();
                    //ocorrencia 0-1
                    _xml.WriteStartElement("pMVAST");//Percentual da margem de valor Adicionado do ICMS ST
                    _xml.WriteString("00");// tam 5
                    _xml.WriteEndElement();
                    //ocorrencia 0-1
                    _xml.WriteStartElement("pRedBCST");//Percentual da Redução de BC do ICMS ST
                    _xml.WriteString("1");// tam 5
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vBCST");//Valor da BC do ICMS ST
                    _xml.WriteString("43195");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("pICMSST");//Alíquota do imposto do ICMS ST
                    _xml.WriteString("4.30");// tam 5
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vICMSST");//Valor do ICMS ST
                    _xml.WriteString("4.30");// tam 15
                    _xml.WriteEndElement();
                    #endregion

                    //para o caso de ICMS40
                    #region ICMS40
                    _xml.WriteStartElement("vICMS");//Valor do ICMS
                    _xml.WriteString("4.30");// tam 5
                    _xml.WriteEndElement();
                    #endregion

                    //para o caso de ICMSPart
                    #region ICMSPart
                    _xml.WriteStartElement("pBCOp");//Percentual da BC operação própria
                    _xml.WriteString("4");// tam 5
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("UFST");//UF para qual é devido o ICMS ST
                    _xml.WriteString("00");// tam 2
                    _xml.WriteEndElement();
                    #endregion

                    //para o caso de ICMS101,201,900
                    #region ICMS101_201_900
                    _xml.WriteStartElement("pCredSN");//Alíquota aplicável de cálculo do crédito (Simples Nacional).
                    _xml.WriteString("00");// tam 5
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vCredICMSSN");//Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (Simples Nacional)
                    _xml.WriteString("00");// tam 15
                    _xml.WriteEndElement();
                    #endregion

                    _xml.WriteEndElement();

                    #endregion

                    _xml.WriteEndElement();
                    #endregion

                    //Grupo do IPI, ocorrencia 0-1
                    #region IPI
                    _xml.WriteStartElement("IPI");
                    //ocorrencia 0-1
                    _xml.WriteStartElement("clEnq");//Classe de enquadramento do IPI para Cigarros e Bebidas
                    _xml.WriteString("2");// tam 5
                    _xml.WriteEndElement();
                    //ocorrencia 0-1
                    _xml.WriteStartElement("CNPJProd");//CNPJ do produtor da
                    //mercadoria, quando diferente
                    //do emitente. Somente para os
                    //casos de exportação direta ou
                    //indireta.
                    _xml.WriteString("2");// tam 14
                    _xml.WriteEndElement();
                    //ocorrencia 0-1
                    _xml.WriteStartElement("cSelo");//Código do selo de controle IPI
                    _xml.WriteString("2");// tam 1-60
                    _xml.WriteEndElement();
                    //ocorrencia 0-1
                    _xml.WriteStartElement("qSelo");//Quantidade de selo de controle
                    _xml.WriteString("2");// tam 1-12
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("cEnq");//Código de Enquadramento Legal do IPI
                    _xml.WriteString("2");// tam 3
                    _xml.WriteEndElement();

                    #region IPITrib
                    _xml.WriteStartElement("IPITrib");//Grupo do CST 00, 49, 50 e 99
                    _xml.WriteStartElement("CST");//Código da situação tributária do IPI
                    _xml.WriteString("2");// tam 2
                    _xml.WriteEndElement();

                    //Informar os campos O10 e O13 caso o cálculo do IPI seja por alíquota ou os campos O11 e O12 caso o cálculo do IPI seja valor por unidade.
                    _xml.WriteStartElement("vBC");//Valor da BC do IPI
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("pIPI");//Alíquota do IPI
                    _xml.WriteString("2");// tam 5
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("qUnid");//Quantidade total na unidade
                    //padrão para tributação
                    //(somente para os produtos
                    //tributados por unidade)
                    _xml.WriteString("2");// tam 3
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vUnid");//Valor por Unidade Tributável
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();
                    _xml.WriteStartElement("vIPI");//Valor do IPI
                    _xml.WriteString("2");// tam 3
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("cEnq");//Código de Enquadramento Legal do IPI
                    _xml.WriteString("2");// tam 3
                    _xml.WriteEndElement();
                    //END IPITRIB
                    _xml.WriteEndElement();
                    #endregion
                    //ou
                    #region IPINT
                    _xml.WriteStartElement("IPINT");//Grupo do CST 01, 02, 03, 04, 51, 52, 53, 54 e 55

                    _xml.WriteStartElement("CST");//Código da situação tributária do IPI
                    _xml.WriteString("2");// tam 2
                    _xml.WriteEndElement();

                    _xml.WriteEndElement();
                    #endregion

                    //fim tag IPI;
                    _xml.WriteEndElement();
                    #endregion
                    //omitido P - Imposto de Importação e filhos
                    //este pis
                    #region PIS
                    _xml.WriteStartElement("PIS");//Grupo do PIS
                    #region PISComum
                    int _1 = 0;
                    switch (_1)
                    {
                        case 0:
                            _xml.WriteStartElement("PISAliq");//Grupo de PIS tributado pela alíquota
                            break;
                        case 1:
                            _xml.WriteStartElement("PISQtde");//Grupo de PIS tributado por Qtde
                            break;
                        case 2:
                            _xml.WriteStartElement("PISNT");//Grupo de PIS não tributado
                            break;
                        case 3:
                            _xml.WriteStartElement("PISOutr");//Grupo de PIS não tributado
                            break;
                    }

                    _xml.WriteStartElement("CST");//Código de Situação Tributária do PIS
                    _xml.WriteString("2");// tam 2
                    _xml.WriteEndElement();

                    #endregion

                    #region PISAliq_PISOutr
                    _xml.WriteStartElement("vBC");//Valor da Base de Cálculo do PIS
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("pPIS");//Alíquota do PIS (em percentual)
                    _xml.WriteString("2");// tam 5
                    _xml.WriteEndElement();

                    #endregion

                    #region PISQtde_PISOutr

                    _xml.WriteStartElement("qBCProd");//Quantidade Vendida
                    _xml.WriteString("2");// tam 16
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vAliqProd");//Alíquota do PIS (em reais)
                    _xml.WriteString("2");// tam 5
                    _xml.WriteEndElement();

                    #endregion

                    //usado em PISAliq,PISQtde,PISOutr
                    _xml.WriteStartElement("vPIS");//Valor do PIS
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();
                    _xml.WriteEndElement();//end tipo do pis..
                    _xml.WriteEndElement();//end PIS...;
                    #endregion
                    //ou este
                    #region PISST
                    _xml.WriteStartElement("PISST");//Grupo de PIS Substituição Tributária

                    _xml.WriteStartElement("vBC");//Valor da Base de Cálculo do PIS
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("pPIS");//Alíquota do PIS (em percentual)
                    _xml.WriteString("2");// tam 5
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("qBCProd");//Quantidade Vendida
                    _xml.WriteString("2");// tam 16
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vAliqProd");//Alíquota do PIS (em reais)
                    _xml.WriteString("2");// tam 5
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vPIS");//Valor do PIS
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteEndElement();
                    #endregion
                    //este COFINS
                    #region COFINS
                    _xml.WriteStartElement("COFINS");//Grupo do COFINS
                    #region COFINSComum
                    switch (_1)
                    {
                        case 0:
                            _xml.WriteStartElement("COFINSAliq");//Grupo de COFINS tributado pela alíquota
                            break;
                        case 1:
                            _xml.WriteStartElement("COFINSQtde");//Grupo de COFINS tributado por Qtde
                            break;
                        case 2:
                            _xml.WriteStartElement("COFINSNT");//Grupo de COFINS não tributado
                            break;
                        case 3:
                            _xml.WriteStartElement("COFINSOutr");//Grupo de COFINS não tributado
                            break;
                    }
                    _xml.WriteStartElement("CST");//Código de Situação Tributária do COFINS
                    _xml.WriteString("2");// tam 2
                    _xml.WriteEndElement();

                    #endregion

                    #region PISAliq_PISOutr
                    _xml.WriteStartElement("vBC");//Valor da Base de Cálculo do COFINS
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("pCOFINS");//Alíquota da COFINS (em percentual)
                    _xml.WriteString("2");// tam 5
                    _xml.WriteEndElement();
                    #endregion

                    #region PISQtde_PISOutr

                    _xml.WriteStartElement("qBCProd");//Quantidade Vendida
                    _xml.WriteString("2");// tam 16
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vAliqProd");//Alíquota do COFINS (em reais)
                    _xml.WriteString("2");// tam 5
                    _xml.WriteEndElement();

                    #endregion

                    //usado em COFINSAliq,COFINSQtde,COFINSOutr
                    _xml.WriteStartElement("vCOFINS");//Valor do COFINS
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteEndElement();//end COFINS...;

                    _xml.WriteEndElement();//end COFINS;
                    #endregion
                    //ou este
                    #region COFINSST
                    _xml.WriteStartElement("COFINSST");//Grupo de COFINS Substituição Tributária

                    _xml.WriteStartElement("vBC");//Valor da Base de Cálculo do COFINS
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("pCOFINS");//Alíquota do COFINS (em percentual)
                    _xml.WriteString("2");// tam 5
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("qBCProd");//Quantidade Vendida
                    _xml.WriteString("2");// tam 16
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vAliqProd");//Alíquota do COFINS (em reais)
                    _xml.WriteString("2");// tam 5
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vCOFINS");//Valor do COFINS
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteEndElement();
                    #endregion
                    //ocorrencia 0-1
                    #region ISSQN
                    _xml.WriteStartElement("ISSQN");//Grupo do ISSQN

                    _xml.WriteStartElement("vBC");//Valor da Base de Cálculo do ISSQN
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vAliq");//Alíquota do ISSQN
                    _xml.WriteString("2");// tam 5
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("vISSQN");//Valor do ISSQN
                    _xml.WriteString("2");// tam 15
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("cMunFG");//Código do município de ocorrência do fato gerador do ISSQN
                    _xml.WriteString("2");// tam 7
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("cListServ");//Item da Lista de Serviços
                    _xml.WriteString("2");// tam 3-4
                    _xml.WriteEndElement();

                    _xml.WriteStartElement("cSitTrib");//Código de Tributação do ISSQN
                    _xml.WriteString("2");// tam 1
                    _xml.WriteEndElement();

                    _xml.WriteEndElement();
                    #endregion
                    _xml.WriteEndElement();//end element Imposto
                    #endregion

                    _xml.WriteStartElement("infAdProd");//Informações Adicionais do Produto
                    _xml.WriteString("03542907");// tam 500
                    _xml.WriteEndElement();

                    _xml.WriteEndElement();
                    //omitida tag DI e filhos
                    //omitida tag veicProd e filhos
                    //omitida tag med e filhos
                    //omitida tag arma
                    //omitida tag comb
                    incrementoProd++;
                }
                //fim det
                #endregion

                #region Total
                _xml.WriteStartElement("total");//Grupo de Valores Totais da NF-e

                #region ICMSTot

                _xml.WriteStartElement("ICMSTot");//Grupo de Valores Totais referentes ao ICMS

                _xml.WriteStartElement("vBC");//Valor da BC do ICMS
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vICMS");//Valor do ICMS
                _xml.WriteString("4.30");// tam 5
                _xml.WriteEndElement();

                _xml.WriteStartElement("vBCST");//Valor da BC do ICMS ST
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vST");//Valor da BC do ICMS ST
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vProd");//Valor Total Bruto dos Produtos ou Serviços
                _xml.WriteString("863.90");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vFrete");//Valor Total do Frete
                _xml.WriteString("4.3195");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vSeg");//Valor Total do Seguro
                _xml.WriteString("4.3195");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vDesc");//Valor do Desconto
                _xml.WriteString("4.3195");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vII");//Valor Total do II
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vIPI");//Valor do IPI
                _xml.WriteString("2");// tam 3
                _xml.WriteEndElement();

                _xml.WriteStartElement("vPIS");//Valor do PIS
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vCOFINS");//Valor do COFINS
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vOutro");//Outras despesas acessórias
                _xml.WriteString("4.3195");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vNF");//Valor Total da NF-e
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();

                _xml.WriteEndElement();

                #endregion
                //ocorrencia 0-1
                #region ISSQNtot

                _xml.WriteStartElement("ISSQNtot");//Grupo de Valores Totais referentes ao ISSQN
                //ocorrencia 0-1
                _xml.WriteStartElement("vServ");//Valor Total dos Serviços sob não-incidência ou não tributados pelo ICMS
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("vBC");//Valor da BC do ICMS
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("vISS");//Valor Total do ISS
                _xml.WriteString("4.30");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("vPIS");//Valor do PIS
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("vCOFINS");//Valor do COFINS
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();

                _xml.WriteEndElement();

                #endregion
                //ocorrencia 0-1
                #region retTrib

                _xml.WriteStartElement("retTrib");//Grupo de Retenções de Tributos
                //ocorrencia 0-1
                _xml.WriteStartElement("vRetPIS");//Valor Retido de PIS
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("vRetCOFINS");//Valor Retido de COFINS
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("vRetCSLL");//Valor Retido de CSLL
                _xml.WriteString("4.30");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("vBCIRRF");//Base de Cálculo do IRRF
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("vIRRF");//Valor Retido do IRRF
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("vBCRetPrev");//Base de Cálculo da Retenção da Previdência Social
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("vRetPrev");//Valor da Retenção da Previdência Social
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();

                _xml.WriteEndElement();

                #endregion

                _xml.WriteEndElement();
                #endregion

                #region transp

                _xml.WriteStartElement("transp");//Grupo de Informações do Transporte da NF-e

                _xml.WriteStartElement("modFrete");//Modalidade do frete
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();

                #region transporta
                //ocorrencia 0-1
                _xml.WriteStartElement("transporta");//Grupo Transportador
                //ocorrencia 0-1
                _xml.WriteStartElement("CNPJ");//Valor Retido de CSLL
                _xml.WriteString("4.30");// tam 14
                _xml.WriteEndElement();
                //ou
                _xml.WriteStartElement("CPF");//Valor Retido de CSLL
                _xml.WriteString("4.30");// tam 11
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("xNome");//Razão Social ou nome
                _xml.WriteString("2");// tam 1-60
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("IE");//Inscrição Estadual
                _xml.WriteString("2");// tam 0,2-14
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("xEnder");//Endereço Completo
                _xml.WriteString("2");// tam 1-60
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("xMun");//Nome do município
                _xml.WriteString("2");// tam 1-60
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("UF");//Sigla da UF
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();
                _xml.WriteEndElement();
                #endregion

                #region retTransp
                //ocorrencia 0-1
                _xml.WriteStartElement("retTransp");//Grupo de Retenção do ICMS do transporte
                _xml.WriteStartElement("vServ");//Valor do Serviço
                _xml.WriteString("4.30");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vBCRet");//BC da Retenção do ICMS
                _xml.WriteString("4.30");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("pICMSRet");//Alíquota da Retenção
                _xml.WriteString("2");// tam 5
                _xml.WriteEndElement();

                _xml.WriteStartElement("vICMSRet");//Valor do ICMS Retido
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("CFOP");//CFOP
                _xml.WriteString("2");// tam 4
                _xml.WriteEndElement();
                _xml.WriteStartElement("cMunFG");//Código do município de ocorrência do fato gerador do ICMS do transporte
                _xml.WriteString("2");// tam 7
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion

                #region veicTransp
                //ocorrencia 0-1
                _xml.WriteStartElement("veicTransp");//Grupo Veículo

                _xml.WriteStartElement("placa");//Placa do Veículo
                _xml.WriteString("4.30");// tam 1 - 8
                _xml.WriteEndElement();

                _xml.WriteStartElement("UF");//
                _xml.WriteString("4.30");// tam 2
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("RNTC");//Registro Nacional de Transportador de Carga (ANTT)
                _xml.WriteString("2");// tam 5
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion

                #region reboque
                //ocorrencia 0-5
                _xml.WriteStartElement("reboque");//Grupo reboque

                _xml.WriteStartElement("placa");//Placa do Veículo
                _xml.WriteString("4.30");// tam 1 - 8
                _xml.WriteEndElement();

                _xml.WriteStartElement("UF");//
                _xml.WriteString("4.30");// tam 2
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("RNTC");//Registro Nacional de Transportador de Carga (ANTT)
                _xml.WriteString("2");// tam 5
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion
                //OMITIDOS VAGAO E BALSA
                #region vol
                //ocorrencia 0-1
                _xml.WriteStartElement("vol");//Grupo Volumes
                //ocorrencia 0-1
                _xml.WriteStartElement("qVol");//Quantidade de volumes transportados
                _xml.WriteString("4.30");// tam 1-15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("esp");//Espécie dos volumes transportados
                _xml.WriteString("4.30");// tam 1-60
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("marca");//Marca dos volumes transportados
                _xml.WriteString("2");// tam 1-60
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("nVol");//Numeração dos volumes transportados
                _xml.WriteString("2");// tam 1-60
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("pesoL");//Peso Líquido (em kg)
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-1
                _xml.WriteStartElement("pesoB");//Peso Bruto (em kg)
                _xml.WriteString("2");// tam 15
                _xml.WriteEndElement();
                //ocorrencia 0-N
                _xml.WriteStartElement("lacres");//Grupo lacres
                _xml.WriteStartElement("nLacre");//Número dos Lacres
                _xml.WriteString("2");// tam 1-60
                _xml.WriteEndElement();
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion
                _xml.WriteEndElement();
                #endregion

                #region cobr
                _xml.WriteStartElement("cobr");//Grupo de Cobrança
                _xml.WriteStartElement("fat");//Grupo da Fatura
                _xml.WriteStartElement("nFat");//Número da Fatura
                _xml.WriteString("43195");// tam 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("vOrig");//Valor Original da Fatura
                _xml.WriteString("43195");// tam 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("vDesc");//Valor do desconto
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();

                _xml.WriteStartElement("vLiq");//Valor Líquido da Fatura
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();
                _xml.WriteEndElement();
                //ocorrencia 0-n (colocar em um for)
                _xml.WriteStartElement("dup");//Grupo da Duplicata
                _xml.WriteStartElement("nDup");//Número da Duplicata
                _xml.WriteString("43195");// tam 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("dVenc");//Data de vencimento Formato “AAAA-MM-DD”
                _xml.WriteString("43195");//
                _xml.WriteEndElement();

                _xml.WriteStartElement("vDup");//Valor da duplicata
                _xml.WriteString("43195");// tam 15
                _xml.WriteEndElement();
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion

                #region infAdic
                _xml.WriteStartElement("infAdic");//Grupo de Informações Adicionais

                _xml.WriteStartElement("fat");//Informações Adicionais de Interesse do Fisco
                _xml.WriteString("43195");// tam 1-2000
                _xml.WriteEndElement();

                _xml.WriteStartElement("infCpl");//Informações Complementares de interesse do Contribuinte
                _xml.WriteString("43195");// tam 1-5000
                _xml.WriteEndElement();

                #region obsCont
                _xml.WriteStartElement("obsCont");//GGrupo do campo de uso livre do contribuinte

                _xml.WriteStartElement("xCampo");//Identificação do campo
                _xml.WriteString("43195");// tam 1-20
                _xml.WriteEndElement();

                _xml.WriteStartElement("xTexto");//Conteúdo do campo
                _xml.WriteString("43195");// tam 1-60
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion

                #region obsFisco
                _xml.WriteStartElement("obsFisco");//Grupo do campo de uso livre do Fisco

                _xml.WriteStartElement("xCampo");//Identificação do campo
                _xml.WriteString("43195");// tam 1-20
                _xml.WriteEndElement();

                _xml.WriteStartElement("xTexto");//Conteúdo do campo
                _xml.WriteString("43195");// tam 1-60
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion

                #region procRef
                _xml.WriteStartElement("procRef");//Grupo do processo referenciado

                _xml.WriteStartElement("nProc");//Indentificador do processo ou ato concessório
                _xml.WriteString("43195");// tam 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("indProc");//Indicador da origem do processo
                _xml.WriteString("43195");// tam 1
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion
                _xml.WriteEndElement();
                #endregion

                //omitidos ZA - Informações de Comércio Exterior e filhos
                #region compra
                // se tratar de compra publica
                _xml.WriteStartElement("compra");//GGrupo do campo de uso livre do contribuinte

                _xml.WriteStartElement("xNEmp");//Nota de Empenho
                _xml.WriteString("43195");// tam 1-17
                _xml.WriteEndElement();

                _xml.WriteStartElement("xPed");//Pedido
                _xml.WriteString("43195");// tam 1-60
                _xml.WriteEndElement();

                _xml.WriteStartElement("xCont");//Contrato
                _xml.WriteString("43195");// tam 1-60
                _xml.WriteEndElement();

                _xml.WriteEndElement();
                #endregion
                //Omitidos ZC - Informações do Registro de Aquisição de Cana

                //Omitido ZZ - Informações da Assinatura Digital

                //END InfNFE
                _xml.WriteEndElement();//InfNFE
                #endregion
                //end nfe
                _xml.WriteEndElement();//Nfe
                #endregion
                //end envnfe
                _xml.WriteEndElement();//envNFE
                #endregion
                _xml.Close();
                //MessageBox.Show("Arquivo exportado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Gerar XML" + ex.ToString());

            }
        }
    }
}
