﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clinic.WebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BConsulta", Namespace="http://schemas.datacontract.org/2004/07/BibliotecaClasses.model.basic")]
    [System.SerializableAttribute()]
    public partial class BConsulta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodConsultaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HorarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Clinic.WebService.BMedico MedicoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Clinic.WebService.BPaciente PacienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Clinic.WebService.BTipoConsulta TipoConsultaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodConsulta {
            get {
                return this.CodConsultaField;
            }
            set {
                if ((this.CodConsultaField.Equals(value) != true)) {
                    this.CodConsultaField = value;
                    this.RaisePropertyChanged("CodConsulta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Horario {
            get {
                return this.HorarioField;
            }
            set {
                if ((object.ReferenceEquals(this.HorarioField, value) != true)) {
                    this.HorarioField = value;
                    this.RaisePropertyChanged("Horario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.WebService.BMedico Medico {
            get {
                return this.MedicoField;
            }
            set {
                if ((object.ReferenceEquals(this.MedicoField, value) != true)) {
                    this.MedicoField = value;
                    this.RaisePropertyChanged("Medico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.WebService.BPaciente Paciente {
            get {
                return this.PacienteField;
            }
            set {
                if ((object.ReferenceEquals(this.PacienteField, value) != true)) {
                    this.PacienteField = value;
                    this.RaisePropertyChanged("Paciente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.WebService.BTipoConsulta TipoConsulta {
            get {
                return this.TipoConsultaField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoConsultaField, value) != true)) {
                    this.TipoConsultaField = value;
                    this.RaisePropertyChanged("TipoConsulta");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BMedico", Namespace="http://schemas.datacontract.org/2004/07/BibliotecaClasses.model.basic")]
    [System.SerializableAttribute()]
    public partial class BMedico : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Clinic.WebService.BClinica ClinicaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CpfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CrmField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataInscricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SenhaUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UfField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bairro {
            get {
                return this.BairroField;
            }
            set {
                if ((object.ReferenceEquals(this.BairroField, value) != true)) {
                    this.BairroField = value;
                    this.RaisePropertyChanged("Bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cidade {
            get {
                return this.CidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.CidadeField, value) != true)) {
                    this.CidadeField = value;
                    this.RaisePropertyChanged("Cidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.WebService.BClinica Clinica {
            get {
                return this.ClinicaField;
            }
            set {
                if ((object.ReferenceEquals(this.ClinicaField, value) != true)) {
                    this.ClinicaField = value;
                    this.RaisePropertyChanged("Clinica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cpf {
            get {
                return this.CpfField;
            }
            set {
                if ((object.ReferenceEquals(this.CpfField, value) != true)) {
                    this.CpfField = value;
                    this.RaisePropertyChanged("Cpf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Crm {
            get {
                return this.CrmField;
            }
            set {
                if ((object.ReferenceEquals(this.CrmField, value) != true)) {
                    this.CrmField = value;
                    this.RaisePropertyChanged("Crm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DataInscricao {
            get {
                return this.DataInscricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DataInscricaoField, value) != true)) {
                    this.DataInscricaoField = value;
                    this.RaisePropertyChanged("DataInscricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeUser {
            get {
                return this.NomeUserField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeUserField, value) != true)) {
                    this.NomeUserField = value;
                    this.RaisePropertyChanged("NomeUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SenhaUser {
            get {
                return this.SenhaUserField;
            }
            set {
                if ((object.ReferenceEquals(this.SenhaUserField, value) != true)) {
                    this.SenhaUserField = value;
                    this.RaisePropertyChanged("SenhaUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Uf {
            get {
                return this.UfField;
            }
            set {
                if ((object.ReferenceEquals(this.UfField, value) != true)) {
                    this.UfField = value;
                    this.RaisePropertyChanged("Uf");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BPaciente", Namespace="http://schemas.datacontract.org/2004/07/BibliotecaClasses.model.basic")]
    [System.SerializableAttribute()]
    public partial class BPaciente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Clinic.WebService.BConvenio ConvenioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CpfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bairro {
            get {
                return this.BairroField;
            }
            set {
                if ((object.ReferenceEquals(this.BairroField, value) != true)) {
                    this.BairroField = value;
                    this.RaisePropertyChanged("Bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.WebService.BConvenio Convenio {
            get {
                return this.ConvenioField;
            }
            set {
                if ((object.ReferenceEquals(this.ConvenioField, value) != true)) {
                    this.ConvenioField = value;
                    this.RaisePropertyChanged("Convenio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cpf {
            get {
                return this.CpfField;
            }
            set {
                if ((object.ReferenceEquals(this.CpfField, value) != true)) {
                    this.CpfField = value;
                    this.RaisePropertyChanged("Cpf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hora {
            get {
                return this.HoraField;
            }
            set {
                if ((object.ReferenceEquals(this.HoraField, value) != true)) {
                    this.HoraField = value;
                    this.RaisePropertyChanged("Hora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefone {
            get {
                return this.TelefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefoneField, value) != true)) {
                    this.TelefoneField = value;
                    this.RaisePropertyChanged("Telefone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BTipoConsulta", Namespace="http://schemas.datacontract.org/2004/07/BibliotecaClasses.model.basic")]
    [System.SerializableAttribute()]
    public partial class BTipoConsulta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodTipoConsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodTipoCons {
            get {
                return this.CodTipoConsField;
            }
            set {
                if ((this.CodTipoConsField.Equals(value) != true)) {
                    this.CodTipoConsField = value;
                    this.RaisePropertyChanged("CodTipoCons");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BClinica", Namespace="http://schemas.datacontract.org/2004/07/BibliotecaClasses.model.basic")]
    [System.SerializableAttribute()]
    public partial class BClinica : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CnpjField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescEspecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UfField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bairro {
            get {
                return this.BairroField;
            }
            set {
                if ((object.ReferenceEquals(this.BairroField, value) != true)) {
                    this.BairroField = value;
                    this.RaisePropertyChanged("Bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cidade {
            get {
                return this.CidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.CidadeField, value) != true)) {
                    this.CidadeField = value;
                    this.RaisePropertyChanged("Cidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cnpj {
            get {
                return this.CnpjField;
            }
            set {
                if ((object.ReferenceEquals(this.CnpjField, value) != true)) {
                    this.CnpjField = value;
                    this.RaisePropertyChanged("Cnpj");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescEspec {
            get {
                return this.DescEspecField;
            }
            set {
                if ((object.ReferenceEquals(this.DescEspecField, value) != true)) {
                    this.DescEspecField = value;
                    this.RaisePropertyChanged("DescEspec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefone {
            get {
                return this.TelefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefoneField, value) != true)) {
                    this.TelefoneField = value;
                    this.RaisePropertyChanged("Telefone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Uf {
            get {
                return this.UfField;
            }
            set {
                if ((object.ReferenceEquals(this.UfField, value) != true)) {
                    this.UfField = value;
                    this.RaisePropertyChanged("Uf");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BConvenio", Namespace="http://schemas.datacontract.org/2004/07/BibliotecaClasses.model.basic")]
    [System.SerializableAttribute()]
    public partial class BConvenio : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CnpjField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HoraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bairro {
            get {
                return this.BairroField;
            }
            set {
                if ((object.ReferenceEquals(this.BairroField, value) != true)) {
                    this.BairroField = value;
                    this.RaisePropertyChanged("Bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cidade {
            get {
                return this.CidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.CidadeField, value) != true)) {
                    this.CidadeField = value;
                    this.RaisePropertyChanged("Cidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cnpj {
            get {
                return this.CnpjField;
            }
            set {
                if ((object.ReferenceEquals(this.CnpjField, value) != true)) {
                    this.CnpjField = value;
                    this.RaisePropertyChanged("Cnpj");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hora {
            get {
                return this.HoraField;
            }
            set {
                if ((object.ReferenceEquals(this.HoraField, value) != true)) {
                    this.HoraField = value;
                    this.RaisePropertyChanged("Hora");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebService.Service")]
    public interface Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/insertConsulta", ReplyAction="http://tempuri.org/Service/insertConsultaResponse")]
        bool insertConsulta(Clinic.WebService.BConsulta bCos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/insertConsulta", ReplyAction="http://tempuri.org/Service/insertConsultaResponse")]
        System.Threading.Tasks.Task<bool> insertConsultaAsync(Clinic.WebService.BConsulta bCos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/alterConsulta", ReplyAction="http://tempuri.org/Service/alterConsultaResponse")]
        bool alterConsulta(Clinic.WebService.BConsulta bCos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/alterConsulta", ReplyAction="http://tempuri.org/Service/alterConsultaResponse")]
        System.Threading.Tasks.Task<bool> alterConsultaAsync(Clinic.WebService.BConsulta bCos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/deleteConsulta", ReplyAction="http://tempuri.org/Service/deleteConsultaResponse")]
        void deleteConsulta(Clinic.WebService.BConsulta bCos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/deleteConsulta", ReplyAction="http://tempuri.org/Service/deleteConsultaResponse")]
        System.Threading.Tasks.Task deleteConsultaAsync(Clinic.WebService.BConsulta bCos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/listConsulta", ReplyAction="http://tempuri.org/Service/listConsultaResponse")]
        Clinic.WebService.BConsulta[] listConsulta(Clinic.WebService.BConsulta bCos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Service/listConsulta", ReplyAction="http://tempuri.org/Service/listConsultaResponse")]
        System.Threading.Tasks.Task<Clinic.WebService.BConsulta[]> listConsultaAsync(Clinic.WebService.BConsulta bCos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceChannel : Clinic.WebService.Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Clinic.WebService.Service>, Clinic.WebService.Service {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool insertConsulta(Clinic.WebService.BConsulta bCos) {
            return base.Channel.insertConsulta(bCos);
        }
        
        public System.Threading.Tasks.Task<bool> insertConsultaAsync(Clinic.WebService.BConsulta bCos) {
            return base.Channel.insertConsultaAsync(bCos);
        }
        
        public bool alterConsulta(Clinic.WebService.BConsulta bCos) {
            return base.Channel.alterConsulta(bCos);
        }
        
        public System.Threading.Tasks.Task<bool> alterConsultaAsync(Clinic.WebService.BConsulta bCos) {
            return base.Channel.alterConsultaAsync(bCos);
        }
        
        public void deleteConsulta(Clinic.WebService.BConsulta bCos) {
            base.Channel.deleteConsulta(bCos);
        }
        
        public System.Threading.Tasks.Task deleteConsultaAsync(Clinic.WebService.BConsulta bCos) {
            return base.Channel.deleteConsultaAsync(bCos);
        }
        
        public Clinic.WebService.BConsulta[] listConsulta(Clinic.WebService.BConsulta bCos) {
            return base.Channel.listConsulta(bCos);
        }
        
        public System.Threading.Tasks.Task<Clinic.WebService.BConsulta[]> listConsultaAsync(Clinic.WebService.BConsulta bCos) {
            return base.Channel.listConsultaAsync(bCos);
        }
    }
}