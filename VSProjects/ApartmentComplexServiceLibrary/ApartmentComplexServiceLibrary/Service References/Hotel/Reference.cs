﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApartmentComplexServiceLibraryV1.Hotel {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Hotel", Namespace="http://um.si/feri/soa/hotel/v2")]
    [System.SerializableAttribute()]
    public partial class Hotel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long DavcnaStevilkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ApartmentComplexServiceLibraryV1.Hotel.Naslov NaslovField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivHotelaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OpisHotelaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ApartmentComplexServiceLibraryV1.Hotel.Soba[] SeznamSobField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SifraHotelaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TRRHotelaField;
        
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
        public long DavcnaStevilka {
            get {
                return this.DavcnaStevilkaField;
            }
            set {
                if ((this.DavcnaStevilkaField.Equals(value) != true)) {
                    this.DavcnaStevilkaField = value;
                    this.RaisePropertyChanged("DavcnaStevilka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ApartmentComplexServiceLibraryV1.Hotel.Naslov Naslov {
            get {
                return this.NaslovField;
            }
            set {
                if ((object.ReferenceEquals(this.NaslovField, value) != true)) {
                    this.NaslovField = value;
                    this.RaisePropertyChanged("Naslov");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NazivHotela {
            get {
                return this.NazivHotelaField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivHotelaField, value) != true)) {
                    this.NazivHotelaField = value;
                    this.RaisePropertyChanged("NazivHotela");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OpisHotela {
            get {
                return this.OpisHotelaField;
            }
            set {
                if ((object.ReferenceEquals(this.OpisHotelaField, value) != true)) {
                    this.OpisHotelaField = value;
                    this.RaisePropertyChanged("OpisHotela");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ApartmentComplexServiceLibraryV1.Hotel.Soba[] SeznamSob {
            get {
                return this.SeznamSobField;
            }
            set {
                if ((object.ReferenceEquals(this.SeznamSobField, value) != true)) {
                    this.SeznamSobField = value;
                    this.RaisePropertyChanged("SeznamSob");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SifraHotela {
            get {
                return this.SifraHotelaField;
            }
            set {
                if ((object.ReferenceEquals(this.SifraHotelaField, value) != true)) {
                    this.SifraHotelaField = value;
                    this.RaisePropertyChanged("SifraHotela");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TRRHotela {
            get {
                return this.TRRHotelaField;
            }
            set {
                if ((object.ReferenceEquals(this.TRRHotelaField, value) != true)) {
                    this.TRRHotelaField = value;
                    this.RaisePropertyChanged("TRRHotela");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Naslov", Namespace="http://um.si/feri/soa/hotel/v2")]
    [System.SerializableAttribute()]
    public partial class Naslov : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HisnaStevilkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NaslovMemberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ApartmentComplexServiceLibraryV1.Hotel.Posta PostaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PripisHisneStevilkeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UlicaField;
        
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
        public int HisnaStevilka {
            get {
                return this.HisnaStevilkaField;
            }
            set {
                if ((this.HisnaStevilkaField.Equals(value) != true)) {
                    this.HisnaStevilkaField = value;
                    this.RaisePropertyChanged("HisnaStevilka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Naslov")]
        public string NaslovMember {
            get {
                return this.NaslovMemberField;
            }
            set {
                if ((object.ReferenceEquals(this.NaslovMemberField, value) != true)) {
                    this.NaslovMemberField = value;
                    this.RaisePropertyChanged("NaslovMember");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ApartmentComplexServiceLibraryV1.Hotel.Posta Posta {
            get {
                return this.PostaField;
            }
            set {
                if ((object.ReferenceEquals(this.PostaField, value) != true)) {
                    this.PostaField = value;
                    this.RaisePropertyChanged("Posta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PripisHisneStevilke {
            get {
                return this.PripisHisneStevilkeField;
            }
            set {
                if ((object.ReferenceEquals(this.PripisHisneStevilkeField, value) != true)) {
                    this.PripisHisneStevilkeField = value;
                    this.RaisePropertyChanged("PripisHisneStevilke");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ulica {
            get {
                return this.UlicaField;
            }
            set {
                if ((object.ReferenceEquals(this.UlicaField, value) != true)) {
                    this.UlicaField = value;
                    this.RaisePropertyChanged("Ulica");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Soba", Namespace="http://um.si/feri/soa/hotel/v2")]
    [System.SerializableAttribute()]
    public partial class Soba : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CenaSobeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsBalkonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsKlimaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsPogledNaMorjeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ApartmentComplexServiceLibraryV1.Hotel.Lezisce[] LeziscaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NadstropjeSobeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SifraSobeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StevilkaSobeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SteviloPosteljField;
        
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
        public double CenaSobe {
            get {
                return this.CenaSobeField;
            }
            set {
                if ((this.CenaSobeField.Equals(value) != true)) {
                    this.CenaSobeField = value;
                    this.RaisePropertyChanged("CenaSobe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsBalkon {
            get {
                return this.IsBalkonField;
            }
            set {
                if ((this.IsBalkonField.Equals(value) != true)) {
                    this.IsBalkonField = value;
                    this.RaisePropertyChanged("IsBalkon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsKlima {
            get {
                return this.IsKlimaField;
            }
            set {
                if ((this.IsKlimaField.Equals(value) != true)) {
                    this.IsKlimaField = value;
                    this.RaisePropertyChanged("IsKlima");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPogledNaMorje {
            get {
                return this.IsPogledNaMorjeField;
            }
            set {
                if ((this.IsPogledNaMorjeField.Equals(value) != true)) {
                    this.IsPogledNaMorjeField = value;
                    this.RaisePropertyChanged("IsPogledNaMorje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ApartmentComplexServiceLibraryV1.Hotel.Lezisce[] Lezisca {
            get {
                return this.LeziscaField;
            }
            set {
                if ((object.ReferenceEquals(this.LeziscaField, value) != true)) {
                    this.LeziscaField = value;
                    this.RaisePropertyChanged("Lezisca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NadstropjeSobe {
            get {
                return this.NadstropjeSobeField;
            }
            set {
                if ((this.NadstropjeSobeField.Equals(value) != true)) {
                    this.NadstropjeSobeField = value;
                    this.RaisePropertyChanged("NadstropjeSobe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SifraSobe {
            get {
                return this.SifraSobeField;
            }
            set {
                if ((object.ReferenceEquals(this.SifraSobeField, value) != true)) {
                    this.SifraSobeField = value;
                    this.RaisePropertyChanged("SifraSobe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StevilkaSobe {
            get {
                return this.StevilkaSobeField;
            }
            set {
                if ((this.StevilkaSobeField.Equals(value) != true)) {
                    this.StevilkaSobeField = value;
                    this.RaisePropertyChanged("StevilkaSobe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SteviloPostelj {
            get {
                return this.SteviloPosteljField;
            }
            set {
                if ((this.SteviloPosteljField.Equals(value) != true)) {
                    this.SteviloPosteljField = value;
                    this.RaisePropertyChanged("SteviloPostelj");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Posta", Namespace="http://um.si/feri/soa/hotel/v2")]
    [System.SerializableAttribute()]
    public partial class Posta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivPosteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PostnaStevilkaField;
        
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
        public string NazivPoste {
            get {
                return this.NazivPosteField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivPosteField, value) != true)) {
                    this.NazivPosteField = value;
                    this.RaisePropertyChanged("NazivPoste");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PostnaStevilka {
            get {
                return this.PostnaStevilkaField;
            }
            set {
                if ((this.PostnaStevilkaField.Equals(value) != true)) {
                    this.PostnaStevilkaField = value;
                    this.RaisePropertyChanged("PostnaStevilka");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lezisce", Namespace="http://schemas.datacontract.org/2004/07/ProjektHotel")]
    public enum Lezisce : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ZakonskaPostelja = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pograd = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EnoLezisce = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DodatnoLezisce = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Narocnik", Namespace="http://um.si/feri/soa/hotel/v2")]
    [System.SerializableAttribute()]
    public partial class Narocnik : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long DavcnaStevilkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EPostaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KontaktnaStevilkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivNarocnikaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TRRField;
        
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
        public long DavcnaStevilka {
            get {
                return this.DavcnaStevilkaField;
            }
            set {
                if ((this.DavcnaStevilkaField.Equals(value) != true)) {
                    this.DavcnaStevilkaField = value;
                    this.RaisePropertyChanged("DavcnaStevilka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EPosta {
            get {
                return this.EPostaField;
            }
            set {
                if ((object.ReferenceEquals(this.EPostaField, value) != true)) {
                    this.EPostaField = value;
                    this.RaisePropertyChanged("EPosta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string KontaktnaStevilka {
            get {
                return this.KontaktnaStevilkaField;
            }
            set {
                if ((object.ReferenceEquals(this.KontaktnaStevilkaField, value) != true)) {
                    this.KontaktnaStevilkaField = value;
                    this.RaisePropertyChanged("KontaktnaStevilka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NazivNarocnika {
            get {
                return this.NazivNarocnikaField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivNarocnikaField, value) != true)) {
                    this.NazivNarocnikaField = value;
                    this.RaisePropertyChanged("NazivNarocnika");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TRR {
            get {
                return this.TRRField;
            }
            set {
                if ((object.ReferenceEquals(this.TRRField, value) != true)) {
                    this.TRRField = value;
                    this.RaisePropertyChanged("TRR");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Storitev", Namespace="http://um.si/feri/soa/hotel/v2")]
    [System.SerializableAttribute()]
    public partial class Storitev : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CenaStoritveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KolicinaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazivStoritveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OpisStoritveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SifraStoritveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SteviloProstihMestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ApartmentComplexServiceLibraryV1.Hotel.TipStoritve TipStoritveField;
        
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
        public double CenaStoritve {
            get {
                return this.CenaStoritveField;
            }
            set {
                if ((this.CenaStoritveField.Equals(value) != true)) {
                    this.CenaStoritveField = value;
                    this.RaisePropertyChanged("CenaStoritve");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Kolicina {
            get {
                return this.KolicinaField;
            }
            set {
                if ((this.KolicinaField.Equals(value) != true)) {
                    this.KolicinaField = value;
                    this.RaisePropertyChanged("Kolicina");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NazivStoritve {
            get {
                return this.NazivStoritveField;
            }
            set {
                if ((object.ReferenceEquals(this.NazivStoritveField, value) != true)) {
                    this.NazivStoritveField = value;
                    this.RaisePropertyChanged("NazivStoritve");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OpisStoritve {
            get {
                return this.OpisStoritveField;
            }
            set {
                if ((object.ReferenceEquals(this.OpisStoritveField, value) != true)) {
                    this.OpisStoritveField = value;
                    this.RaisePropertyChanged("OpisStoritve");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SifraStoritve {
            get {
                return this.SifraStoritveField;
            }
            set {
                if ((object.ReferenceEquals(this.SifraStoritveField, value) != true)) {
                    this.SifraStoritveField = value;
                    this.RaisePropertyChanged("SifraStoritve");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SteviloProstihMest {
            get {
                return this.SteviloProstihMestField;
            }
            set {
                if ((this.SteviloProstihMestField.Equals(value) != true)) {
                    this.SteviloProstihMestField = value;
                    this.RaisePropertyChanged("SteviloProstihMest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ApartmentComplexServiceLibraryV1.Hotel.TipStoritve TipStoritve {
            get {
                return this.TipStoritveField;
            }
            set {
                if ((this.TipStoritveField.Equals(value) != true)) {
                    this.TipStoritveField = value;
                    this.RaisePropertyChanged("TipStoritve");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipStoritve", Namespace="http://schemas.datacontract.org/2004/07/ProjektHotel")]
    public enum TipStoritve : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Šport = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Hrana = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Zabava = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sprostitev = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://um.si/feri/soa/hotel/v2", ConfigurationName="Hotel.HotelService")]
    public interface HotelService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/PridobiSeznamHotelov", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/PridobiSeznamHotelovResponse")]
        ApartmentComplexServiceLibraryV1.Hotel.Hotel[] PridobiSeznamHotelov();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/PridobiSeznamHotelov", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/PridobiSeznamHotelovResponse")]
        System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Hotel.Hotel[]> PridobiSeznamHotelovAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/PreveriRazpolozljivostSob", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/PreveriRazpolozljivostSobResponse")]
        ApartmentComplexServiceLibraryV1.Hotel.Soba[] PreveriRazpolozljivostSob(int stPostelj, System.DateTime DatumOd, System.DateTime DatumDo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/PreveriRazpolozljivostSob", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/PreveriRazpolozljivostSobResponse")]
        System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Hotel.Soba[]> PreveriRazpolozljivostSobAsync(int stPostelj, System.DateTime DatumOd, System.DateTime DatumDo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/RezervirajSobo", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/RezervirajSoboResponse")]
        bool RezervirajSobo(string sifraSobe, ApartmentComplexServiceLibraryV1.Hotel.Narocnik narocnik, System.DateTime datumOd, System.DateTime datumDo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/RezervirajSobo", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/RezervirajSoboResponse")]
        System.Threading.Tasks.Task<bool> RezervirajSoboAsync(string sifraSobe, ApartmentComplexServiceLibraryV1.Hotel.Narocnik narocnik, System.DateTime datumOd, System.DateTime datumDo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/PregledStoritev", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/PregledStoritevResponse")]
        ApartmentComplexServiceLibraryV1.Hotel.Storitev[] PregledStoritev();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/PregledStoritev", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/PregledStoritevResponse")]
        System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Hotel.Storitev[]> PregledStoritevAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/PregledStoritevByType", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/PregledStoritevByTypeResponse")]
        ApartmentComplexServiceLibraryV1.Hotel.Storitev[] PregledStoritevByType(ApartmentComplexServiceLibraryV1.Hotel.TipStoritve tipStoritve);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/PregledStoritevByType", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/PregledStoritevByTypeResponse")]
        System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Hotel.Storitev[]> PregledStoritevByTypeAsync(ApartmentComplexServiceLibraryV1.Hotel.TipStoritve tipStoritve);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/PreveriRazpolozljivostStoritve", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/PreveriRazpolozljivostStoritveRespons" +
            "e")]
        bool PreveriRazpolozljivostStoritve(string sifraStoritve, int stLjudi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/PreveriRazpolozljivostStoritve", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/PreveriRazpolozljivostStoritveRespons" +
            "e")]
        System.Threading.Tasks.Task<bool> PreveriRazpolozljivostStoritveAsync(string sifraStoritve, int stLjudi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/RezervirajStoritev", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/RezervirajStoritevResponse")]
        bool RezervirajStoritev(string sifraStoritve, int stLjudi, System.DateTime datum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://um.si/feri/soa/hotel/v2/HotelService/RezervirajStoritev", ReplyAction="http://um.si/feri/soa/hotel/v2/HotelService/RezervirajStoritevResponse")]
        System.Threading.Tasks.Task<bool> RezervirajStoritevAsync(string sifraStoritve, int stLjudi, System.DateTime datum);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HotelServiceChannel : ApartmentComplexServiceLibraryV1.Hotel.HotelService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HotelServiceClient : System.ServiceModel.ClientBase<ApartmentComplexServiceLibraryV1.Hotel.HotelService>, ApartmentComplexServiceLibraryV1.Hotel.HotelService {
        
        public HotelServiceClient() {
        }
        
        public HotelServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HotelServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ApartmentComplexServiceLibraryV1.Hotel.Hotel[] PridobiSeznamHotelov() {
            return base.Channel.PridobiSeznamHotelov();
        }
        
        public System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Hotel.Hotel[]> PridobiSeznamHotelovAsync() {
            return base.Channel.PridobiSeznamHotelovAsync();
        }
        
        public ApartmentComplexServiceLibraryV1.Hotel.Soba[] PreveriRazpolozljivostSob(int stPostelj, System.DateTime DatumOd, System.DateTime DatumDo) {
            return base.Channel.PreveriRazpolozljivostSob(stPostelj, DatumOd, DatumDo);
        }
        
        public System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Hotel.Soba[]> PreveriRazpolozljivostSobAsync(int stPostelj, System.DateTime DatumOd, System.DateTime DatumDo) {
            return base.Channel.PreveriRazpolozljivostSobAsync(stPostelj, DatumOd, DatumDo);
        }
        
        public bool RezervirajSobo(string sifraSobe, ApartmentComplexServiceLibraryV1.Hotel.Narocnik narocnik, System.DateTime datumOd, System.DateTime datumDo) {
            return base.Channel.RezervirajSobo(sifraSobe, narocnik, datumOd, datumDo);
        }
        
        public System.Threading.Tasks.Task<bool> RezervirajSoboAsync(string sifraSobe, ApartmentComplexServiceLibraryV1.Hotel.Narocnik narocnik, System.DateTime datumOd, System.DateTime datumDo) {
            return base.Channel.RezervirajSoboAsync(sifraSobe, narocnik, datumOd, datumDo);
        }
        
        public ApartmentComplexServiceLibraryV1.Hotel.Storitev[] PregledStoritev() {
            return base.Channel.PregledStoritev();
        }
        
        public System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Hotel.Storitev[]> PregledStoritevAsync() {
            return base.Channel.PregledStoritevAsync();
        }
        
        public ApartmentComplexServiceLibraryV1.Hotel.Storitev[] PregledStoritevByType(ApartmentComplexServiceLibraryV1.Hotel.TipStoritve tipStoritve) {
            return base.Channel.PregledStoritevByType(tipStoritve);
        }
        
        public System.Threading.Tasks.Task<ApartmentComplexServiceLibraryV1.Hotel.Storitev[]> PregledStoritevByTypeAsync(ApartmentComplexServiceLibraryV1.Hotel.TipStoritve tipStoritve) {
            return base.Channel.PregledStoritevByTypeAsync(tipStoritve);
        }
        
        public bool PreveriRazpolozljivostStoritve(string sifraStoritve, int stLjudi) {
            return base.Channel.PreveriRazpolozljivostStoritve(sifraStoritve, stLjudi);
        }
        
        public System.Threading.Tasks.Task<bool> PreveriRazpolozljivostStoritveAsync(string sifraStoritve, int stLjudi) {
            return base.Channel.PreveriRazpolozljivostStoritveAsync(sifraStoritve, stLjudi);
        }
        
        public bool RezervirajStoritev(string sifraStoritve, int stLjudi, System.DateTime datum) {
            return base.Channel.RezervirajStoritev(sifraStoritve, stLjudi, datum);
        }
        
        public System.Threading.Tasks.Task<bool> RezervirajStoritevAsync(string sifraStoritve, int stLjudi, System.DateTime datum) {
            return base.Channel.RezervirajStoritevAsync(sifraStoritve, stLjudi, datum);
        }
    }
}
