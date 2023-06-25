using System.Text;

namespace GestaoReceitas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (!File.Exists("UtilizadoresSchema.xsd"))
            {
                string xmlContent = @"<?xml version=""1.0"" encoding=""utf-8""?>
<xs:schema id=""Utilizadores""
    targetNamespace=""http://tempuri.org/Utilizadores.xsd""
    elementFormDefault=""qualified""
    xmlns=""http://tempuri.org/Utilizadores.xsd""
    xmlns:mstns=""http://tempuri.org/Utilizadores.xsd""
    xmlns:xs=""http://www.w3.org/2001/XMLSchema""
>

    <!-- Definição do elemento ""utilizadores"" -->
    <xs:element name=""utilizadores"">
        <xs:complexType>
            <xs:sequence>
                <xs:element name=""utilizador"" minOccurs=""0"" maxOccurs=""unbounded"">
                    <xs:complexType>
                        <xs:sequence>
                            <xs:element name=""id"" type=""xs:int""/>
                            <xs:element name=""nome"" type=""xs:string""/>
                            <xs:element name=""username"" type=""xs:string""/>
                            <xs:element name=""password"" type=""xs:string""/>
                        </xs:sequence>
                    </xs:complexType>
                </xs:element>
            </xs:sequence>
        </xs:complexType>
    </xs:element>
</xs:schema>";

                // Specify the file path and name
                string filePath = "UtilizadoresSchema.xsd";

                // Write the XML content to the file
                try
                {
                    File.WriteAllText(filePath, xmlContent, Encoding.UTF8);

                } catch (Exception e)
                {
                    MessageBox.Show("Erro a escrever o schema de Utilizadores");
                    return;
                }

                if (!File.Exists("ReceitasSchema.xsd"))
                {
                    string xmlContentReceitas = @"<?xml version=""1.0"" encoding=""utf-8""?>
<xs:schema id=""Receitas""
    targetNamespace=""http://tempuri.org/Receitas.xsd""
    elementFormDefault=""qualified""
    xmlns=""http://tempuri.org/Receitas.xsd""
    xmlns:mstns=""http://tempuri.org/Receitas.xsd""
    xmlns:xs=""http://www.w3.org/2001/XMLSchema""
>

	<!-- Definição do tipo ""unidade"" -->
	<xs:simpleType name=""unidade"">
		<xs:restriction base=""xs:string"">
			<xs:enumeration value=""Gramas""/>
			<xs:enumeration value=""Kilogramas""/>
			<xs:enumeration value=""Miligramas""/>
			<xs:enumeration value=""Litros""/>
			<xs:enumeration value=""Mililitros""/>
			<xs:enumeration value=""Colheres de Chá""/>
			<xs:enumeration value=""Colheres de Sopa""/>
			<xs:enumeration value=""Xícaras""/>
			<xs:enumeration value=""Unidades""/>
		</xs:restriction>
	</xs:simpleType>

	<!-- Definição do elemento ""receitas"" como container para múltiplas ""receita"" -->
	<xs:element name=""receitas"">
		<xs:complexType>
			<xs:sequence>
				<xs:element name=""receita"" minOccurs=""0"" maxOccurs=""unbounded"">
					<xs:complexType>
						<xs:sequence>
							<xs:element name=""id"" type=""xs:int""/>
							<xs:element name=""nome"" type=""xs:string""/>
							<xs:element name=""categoria"" type=""xs:string""/>
							<xs:element name=""dificuldade"" type=""xs:string""/>
							<xs:element name=""porcoes"" type=""xs:decimal""/>
							<xs:element name=""tempo"" type=""xs:int""/>
							<xs:element name=""descricao"" type=""xs:string""/>
							<xs:element name=""ingredientes"">
								<xs:complexType>
									<xs:sequence>
										<xs:element name=""ingrediente"" maxOccurs=""unbounded"">
											<xs:complexType>
												<xs:sequence>
													<xs:element name=""nome"" type=""xs:string""/>
													<xs:element name=""quantidade"" type=""xs:decimal""/>
													<xs:element name=""unidade"" type=""unidade""/>
												</xs:sequence>
											</xs:complexType>
										</xs:element>
									</xs:sequence>
								</xs:complexType>
							</xs:element>
							<xs:element name=""preparacao"" type=""xs:string""/>
						</xs:sequence>
					</xs:complexType>
				</xs:element>
			</xs:sequence>
		</xs:complexType>
	</xs:element>
</xs:schema>
>";

                    // Specify the file path and name
                    string filePathReceitas = "ReceitasSchema.xsd";

                    // Write the XML content to the file
                    try
                    {
                        File.WriteAllText(filePathReceitas, xmlContentReceitas, Encoding.UTF8);

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Erro a escrever o schema de Utilizadores");
                        return;
                    }
                }
            Application.Run(new Login());

        }
    }
}