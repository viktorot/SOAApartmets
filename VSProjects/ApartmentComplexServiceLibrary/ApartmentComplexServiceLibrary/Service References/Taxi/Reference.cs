﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApartmentComplexServiceLibraryV1.Taxi {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Narocilo", Namespace="http://schemas.datacontract.org/2004/07/TaksiSluzba.Data")]
    [System.SerializableAttribute()]
    public partial class Narocilo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CiljRelacijeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnaslovUporabnikaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdNarocilaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImeUporabnikaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PrevzemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PriimekUporabnikaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StartRelacijeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SteviloOsebField;
        
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
        public string CiljRelacije {
            get {
                return this.CiljRelacijeField;
            }
            set {
                if ((object.ReferenceEquals(this.CiljRelacijeField, value) != true)) {
                    this.CiljRelacijeField = value;
                    this.RaisePropertyChanged("CiljRelacije");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EnaslovUporabnika {
            get {
                return this.EnaslovUporabnikaField;
            }
            set {
                if ((object.ReferenceEquals(this.EnaslovUporabnikaField, value) != true)) {
                    this.EnaslovUporabnikaField = value;
                    this.RaisePropertyChanged("EnaslovUporabnika");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdNarocila {
            get {
                return this.IdNarocilaField;
            }
            set {
                if ((this.IdNarocilaField.Equals(value) != true)) {
                    this.IdNarocilaField = value;
                    this.RaisePropertyChanged("IdNarocila");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImeUporabnika {
            get {
                return this.ImeUporabnikaField;
            }
            set {
                if ((object.ReferenceEquals(this.ImeUporabnikaField, value) != true)) {
                    this.ImeUporabnikaField = value;
                    this.RaisePropertyChanged("ImeUporabnika");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Prevzem {
            get {
                return this.PrevzemField;
            }
            set {
                if ((this.PrevzemField.Equals(value) != true)) {
                    this.PrevzemField = value;
                    this.RaisePropertyChanged("Prevzem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PriimekUporabnika {
            get {
                return this.PriimekUporabnikaField;
            }
            set {
                if ((object.ReferenceEquals(this.PriimekUporabnikaField, value) != true)) {
                    this.PriimekUporabnikaField = value;
                    this.RaisePropertyChanged("PriimekUporabnika");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StartRelacije {
            get {
                return this.StartRelacijeField;
            }
            set {
                if ((object.ReferenceEquals(this.StartRelacijeField, value) != true)) {
                    this.StartRelacijeField = value;
                    this.RaisePropertyChanged("StartRelacije");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SteviloOseb {
            get {
                return this.SteviloOsebField;
            }
            set {
                if ((this.SteviloOsebField.Equals(value) != true)) {
                    this.SteviloOsebField = value;
                    this.RaisePropertyChanged("SteviloOseb");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="JaviNapako", Namespace="www.projekt-taksi.org/7/12/2014")]
    [System.SerializableAttribute()]
    public partial class JaviNapako : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperacijaSOAPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string javiSporociloField;
        
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
        public string OperacijaSOAP {
            get {
                return this.OperacijaSOAPField;
            }
            set {
                if ((object.ReferenceEquals(this.OperacijaSOAPField, value) != true)) {
                    this.OperacijaSOAPField = value;
                    this.RaisePropertyChanged("OperacijaSOAP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string javiSporocilo {
            get {
                return this.javiSporociloField;
            }
            set {
                if ((object.ReferenceEquals(this.javiSporociloField, value) != true)) {
                    this.javiSporociloField = value;
                    this.RaisePropertyChanged("javiSporocilo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Cenik", Namespace="http://schemas.datacontract.org/2004/07/TaksiSluzba.Data")]
    [System.SerializableAttribute()]
    public partial class Cenik : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CakalnaUraField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCenikaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double KilometerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double StartninaField;
        
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
        public double CakalnaUra {
            get {
                return this.CakalnaUraField;
            }
            set {
                if ((this.CakalnaUraField.Equals(value) != true)) {
                    this.CakalnaUraField = value;
                    this.RaisePropertyChanged("CakalnaUra");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCenika {
            get {
                return this.IdCenikaField;
            }
            set {
                if ((this.IdCenikaField.Equals(value) != true)) {
                    this.IdCenikaField = value;
                    this.RaisePropertyChanged("IdCenika");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Kilometer {
            get {
                return this.KilometerField;
            }
            set {
                if ((this.KilometerField.Equals(value) != true)) {
                    this.KilometerField = value;
                    this.RaisePropertyChanged("Kilometer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Naziv {
            get {
                return this.NazivField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivField, value) != true)) {
                    this.NazivField = value;
                    this.RaisePropertyChanged("Naziv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Startnina {
            get {
                return this.StartninaField;
            }
            set {
                if ((this.StartninaField.Equals(value) != true)) {
                    this.StartninaField = value;
                    this.RaisePropertyChanged("Startnina");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Vozila", Namespace="http://schemas.datacontract.org/2004/07/TaksiSluzba.Data")]
    [System.SerializableAttribute()]
    public partial class Vozila : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DodatnaOpremaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdVozilaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LetnikField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivVozilaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SteviloSedezevField;
        
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
        public string DodatnaOprema {
            get {
                return this.DodatnaOpremaField;
            }
            set {
                if ((object.ReferenceEquals(this.DodatnaOpremaField, value) != true)) {
                    this.DodatnaOpremaField = value;
                    this.RaisePropertyChanged("DodatnaOprema");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdVozila {
            get {
                return this.IdVozilaField;
            }
            set {
                if ((this.IdVozilaField.Equals(value) != true)) {
                    this.IdVozilaField = value;
                    this.RaisePropertyChanged("IdVozila");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Letnik {
            get {
                return this.LetnikField;
            }
            set {
                if ((this.LetnikField.Equals(value) != true)) {
                    this.LetnikField = value;
                    this.RaisePropertyChanged("Letnik");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NazivVozila {
            get {
                return this.NazivVozilaField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivVozilaField, value) != true)) {
                    this.NazivVozilaField = value;
                    this.RaisePropertyChanged("NazivVozila");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SteviloSedezev {
            get {
                return this.SteviloSedezevField;
            }
            set {
                if ((this.SteviloSedezevField.Equals(value) != true)) {
                    this.SteviloSedezevField = value;
                    this.RaisePropertyChanged("SteviloSedezev");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Pritozba", Namespace="http://schemas.datacontract.org/2004/07/TaksiSluzba.Data")]
    [System.SerializableAttribute()]
    public partial class Pritozba : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CasDogodkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KrajDogodkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OpisField;
        
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
        public System.DateTime CasDogodka {
            get {
                return this.CasDogodkaField;
            }
            set {
                if ((this.CasDogodkaField.Equals(value) != true)) {
                    this.CasDogodkaField = value;
                    this.RaisePropertyChanged("CasDogodka");
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
        public string KrajDogodka {
            get {
                return this.KrajDogodkaField;
            }
            set {
                if ((object.ReferenceEquals(this.KrajDogodkaField, value) != true)) {
                    this.KrajDogodkaField = value;
                    this.RaisePropertyChanged("KrajDogodka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Opis {
            get {
                return this.OpisField;
            }
            set {
                if ((object.ReferenceEquals(this.OpisField, value) != true)) {
                    this.OpisField = value;
                    this.RaisePropertyChanged("Opis");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="www.projekt-taksi.org/7/12/2014)", ConfigurationName="Taxi.Uporabniki")]
    public interface Uporabniki {
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/OddajNarocilo", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/OddajNarociloResponse")]
        void OddajNarocilo(ApartmentComplexServiceLibraryV1.Taxi.Narocilo oddaj);
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/OddajNarocilo", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/OddajNarociloResponse")]
        System.Threading.Tasks.Task OddajNarociloAsync(ApartmentComplexServiceLibraryV1.Taxi.Narocilo oddaj);
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiLastnaNarocila", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiLastnaNarocilaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ApartmentComplexServiceLibraryV1.Taxi.JaviNapako), Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiLastnaNarocilaJaviNapakoFault", Name="JaviNapako", Namespace="www.projekt-taksi.org/7/12/2014")]
        ApartmentComplexServiceLibraryV1.Taxi.Narocilo[] DobiLastnaNarocila(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiLastnaNarocila", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiLastnaNarocilaResponse")]
        System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Taxi.Narocilo[]> DobiLastnaNarocilaAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiCenik", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiCenikResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ApartmentComplexServiceLibraryV1.Taxi.JaviNapako), Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiCenikJaviNapakoFault", Name="JaviNapako", Namespace="www.projekt-taksi.org/7/12/2014")]
        ApartmentComplexServiceLibraryV1.Taxi.Cenik[] DobiCenik();
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiCenik", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiCenikResponse")]
        System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Taxi.Cenik[]> DobiCenikAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiVozila", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiVozilaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ApartmentComplexServiceLibraryV1.Taxi.JaviNapako), Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiVozilaJaviNapakoFault", Name="JaviNapako", Namespace="www.projekt-taksi.org/7/12/2014")]
        ApartmentComplexServiceLibraryV1.Taxi.Vozila[] DobiVozila();
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiVozila", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/DobiVozilaResponse")]
        System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Taxi.Vozila[]> DobiVozilaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/OddajPritozbo", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/OddajPritozboResponse")]
        void OddajPritozbo(ApartmentComplexServiceLibraryV1.Taxi.Pritozba pritozba);
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/OddajPritozbo", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/OddajPritozboResponse")]
        System.Threading.Tasks.Task OddajPritozboAsync(ApartmentComplexServiceLibraryV1.Taxi.Pritozba pritozba);
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/PreventivnaCenaVoznje", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/PreventivnaCenaVoznjeResponse")]
        double PreventivnaCenaVoznje(int id_cenika, double st_kilometrov, int minuteCakanja);
        
        [System.ServiceModel.OperationContractAttribute(Action="www.projekt-taksi.org/7/12/2014)/Uporabniki/PreventivnaCenaVoznje", ReplyAction="www.projekt-taksi.org/7/12/2014)/Uporabniki/PreventivnaCenaVoznjeResponse")]
        System.Threading.Tasks.Task<double> PreventivnaCenaVoznjeAsync(int id_cenika, double st_kilometrov, int minuteCakanja);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UporabnikiChannel : ApartmentComplexServiceLibraryV1.Taxi.Uporabniki, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UporabnikiClient : System.ServiceModel.ClientBase<ApartmentComplexServiceLibraryV1.Taxi.Uporabniki>, ApartmentComplexServiceLibraryV1.Taxi.Uporabniki {
        
        public UporabnikiClient() {
        }
        
        public UporabnikiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UporabnikiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UporabnikiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UporabnikiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void OddajNarocilo(ApartmentComplexServiceLibraryV1.Taxi.Narocilo oddaj) {
            base.Channel.OddajNarocilo(oddaj);
        }
        
        public System.Threading.Tasks.Task OddajNarociloAsync(ApartmentComplexServiceLibraryV1.Taxi.Narocilo oddaj) {
            return base.Channel.OddajNarociloAsync(oddaj);
        }
        
        public ApartmentComplexServiceLibraryV1.Taxi.Narocilo[] DobiLastnaNarocila(string email) {
            return base.Channel.DobiLastnaNarocila(email);
        }
        
        public System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Taxi.Narocilo[]> DobiLastnaNarocilaAsync(string email) {
            return base.Channel.DobiLastnaNarocilaAsync(email);
        }
        
        public ApartmentComplexServiceLibraryV1.Taxi.Cenik[] DobiCenik() {
            return base.Channel.DobiCenik();
        }
        
        public System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Taxi.Cenik[]> DobiCenikAsync() {
            return base.Channel.DobiCenikAsync();
        }
        
        public ApartmentComplexServiceLibraryV1.Taxi.Vozila[] DobiVozila() {
            return base.Channel.DobiVozila();
        }
        
        public System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Taxi.Vozila[]> DobiVozilaAsync() {
            return base.Channel.DobiVozilaAsync();
        }
        
        public void OddajPritozbo(ApartmentComplexServiceLibraryV1.Taxi.Pritozba pritozba) {
            base.Channel.OddajPritozbo(pritozba);
        }
        
        public System.Threading.Tasks.Task OddajPritozboAsync(ApartmentComplexServiceLibraryV1.Taxi.Pritozba pritozba) {
            return base.Channel.OddajPritozboAsync(pritozba);
        }
        
        public double PreventivnaCenaVoznje(int id_cenika, double st_kilometrov, int minuteCakanja) {
            return base.Channel.PreventivnaCenaVoznje(id_cenika, st_kilometrov, minuteCakanja);
        }
        
        public System.Threading.Tasks.Task<double> PreventivnaCenaVoznjeAsync(int id_cenika, double st_kilometrov, int minuteCakanja) {
            return base.Channel.PreventivnaCenaVoznjeAsync(id_cenika, st_kilometrov, minuteCakanja);
        }
    }
}
