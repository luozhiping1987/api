﻿#pragma warning disable 1717
namespace Java.Security.Cert
{
		/// <java-name>
		/// java/security/cert/Certificate
		/// </java-name>
		[Dot42.DexImport("java/security/cert/Certificate", AccessFlags = 1057)]
		public abstract partial class Certificate : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal Certificate(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey publicKey) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey publicKey, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// writeReplace
				/// </java-name>
				[Dot42.DexImport("writeReplace", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object WriteReplace() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal Certificate() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public abstract byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				/// <java-name>
				/// getPublicKey
				/// </java-name>
				public abstract global::Java.Security.IPublicKey PublicKey
				{
						[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// java/security/cert/Certificate$CertificateRep
				/// </java-name>
				[Dot42.DexImport("java/security/cert/Certificate$CertificateRep", AccessFlags = 12)]
				protected internal partial class CertificateRep : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;[B)V", AccessFlags = 4)]
						protected internal CertificateRep(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;[B)V", AccessFlags = 4, IgnoreFromJava = true)]
						protected internal CertificateRep(string @string, byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readResolve
						/// </java-name>
						[Dot42.DexImport("readResolve", "()Ljava/lang/Object;", AccessFlags = 4)]
						protected internal virtual object ReadResolve() /* MethodBuilder.Create */ 
						{
								return default(object);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal CertificateRep() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// java/security/cert/CertificateEncodingException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateEncodingException", AccessFlags = 33)]
		public partial class CertificateEncodingException : global::Java.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateEncodingException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateEncodingException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateEncodingException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateEncodingException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/cert/CertificateException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateException", AccessFlags = 33)]
		public partial class CertificateException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/cert/CertificateExpiredException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateExpiredException", AccessFlags = 33)]
		public partial class CertificateExpiredException : global::Java.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateExpiredException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateExpiredException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/cert/CertificateFactory
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateFactory", AccessFlags = 33)]
		public partial class CertificateFactory
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertificateFactorySpi;Ljava/security/Provider;Ljava/lang/Str" +
    "ing;)V", AccessFlags = 4)]
				protected internal CertificateFactory(global::Java.Security.Cert.CertificateFactorySpi certificateFactorySpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertificateFactory;", AccessFlags = 25)]
				public static global::Java.Security.Cert.CertificateFactory GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertificateFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertificateFactory;", AccessFlags = 25)]
				public static global::Java.Security.Cert.CertificateFactory GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertificateFactory);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertificateFactor" +
    "y;", AccessFlags = 25)]
				public static global::Java.Security.Cert.CertificateFactory GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertificateFactory);
				}

				/// <java-name>
				/// generateCertificate
				/// </java-name>
				[Dot42.DexImport("generateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;", AccessFlags = 17)]
				public global::Java.Security.Cert.Certificate GenerateCertificate(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.Certificate);
				}

				/// <java-name>
				/// generateCertPath
				/// </java-name>
				[Dot42.DexImport("generateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;", AccessFlags = 17)]
				public global::Java.Security.Cert.CertPath GenerateCertPath(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <java-name>
				/// generateCertPath
				/// </java-name>
				[Dot42.DexImport("generateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;", AccessFlags = 17)]
				public global::Java.Security.Cert.CertPath GenerateCertPath(global::Java.IO.InputStream inputStream, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <java-name>
				/// generateCertPath
				/// </java-name>
				[Dot42.DexImport("generateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;", AccessFlags = 17, Signature = "(Ljava/util/List<+Ljava/security/cert/Certificate;>;)Ljava/security/cert/CertPath" +
    ";")]
				public global::Java.Security.Cert.CertPath GenerateCertPath(global::Java.Util.IList<global::Java.Security.Cert.Certificate> list) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <java-name>
				/// generateCertificates
				/// </java-name>
				[Dot42.DexImport("generateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;", AccessFlags = 17, Signature = "(Ljava/io/InputStream;)Ljava/util/Collection<+Ljava/security/cert/Certificate;>;")]
				public global::Java.Util.ICollection<global::Java.Security.Cert.Certificate> GenerateCertificates(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::Java.Security.Cert.Certificate>);
				}

				/// <java-name>
				/// generateCRL
				/// </java-name>
				[Dot42.DexImport("generateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;", AccessFlags = 17)]
				public global::Java.Security.Cert.CRL GenerateCRL(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CRL);
				}

				/// <java-name>
				/// generateCRLs
				/// </java-name>
				[Dot42.DexImport("generateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;", AccessFlags = 17, Signature = "(Ljava/io/InputStream;)Ljava/util/Collection<+Ljava/security/cert/CRL;>;")]
				public global::Java.Util.ICollection<global::Java.Security.Cert.CRL> GenerateCRLs(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::Java.Security.Cert.CRL>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CertificateFactory() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCertPathEncodings
				/// </java-name>
				public global::Java.Util.IIterator<string> CertPathEncodings
				{
						[Dot42.DexImport("getCertPathEncodings", "()Ljava/util/Iterator;", AccessFlags = 17, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IIterator<string>); }
				}

		}

		/// <java-name>
		/// java/security/cert/CertificateFactorySpi
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateFactorySpi", AccessFlags = 1057)]
		public abstract partial class CertificateFactorySpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateFactorySpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGenerateCertificate
				/// </java-name>
				[Dot42.DexImport("engineGenerateCertificate", "(Ljava/io/InputStream;)Ljava/security/cert/Certificate;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.Certificate EngineGenerateCertificate(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateCertificates
				/// </java-name>
				[Dot42.DexImport("engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;", AccessFlags = 1025, Signature = "(Ljava/io/InputStream;)Ljava/util/Collection<+Ljava/security/cert/Certificate;>;")]
				public abstract global::Java.Util.ICollection<global::Java.Security.Cert.Certificate> EngineGenerateCertificates(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateCRL
				/// </java-name>
				[Dot42.DexImport("engineGenerateCRL", "(Ljava/io/InputStream;)Ljava/security/cert/CRL;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.CRL EngineGenerateCRL(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateCRLs
				/// </java-name>
				[Dot42.DexImport("engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;", AccessFlags = 1025, Signature = "(Ljava/io/InputStream;)Ljava/util/Collection<+Ljava/security/cert/CRL;>;")]
				public abstract global::Java.Util.ICollection<global::Java.Security.Cert.CRL> EngineGenerateCRLs(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGenerateCertPath
				/// </java-name>
				[Dot42.DexImport("engineGenerateCertPath", "(Ljava/io/InputStream;)Ljava/security/cert/CertPath;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.CertPath EngineGenerateCertPath(global::Java.IO.InputStream inputStream) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <java-name>
				/// engineGenerateCertPath
				/// </java-name>
				[Dot42.DexImport("engineGenerateCertPath", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/security/cert/CertPath;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.CertPath EngineGenerateCertPath(global::Java.IO.InputStream inputStream, string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <java-name>
				/// engineGenerateCertPath
				/// </java-name>
				[Dot42.DexImport("engineGenerateCertPath", "(Ljava/util/List;)Ljava/security/cert/CertPath;", AccessFlags = 1, Signature = "(Ljava/util/List<+Ljava/security/cert/Certificate;>;)Ljava/security/cert/CertPath" +
    ";")]
				public virtual global::Java.Security.Cert.CertPath EngineGenerateCertPath(global::Java.Util.IList<global::Java.Security.Cert.Certificate> list) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPath);
				}

				/// <java-name>
				/// engineGetCertPathEncodings
				/// </java-name>
				[Dot42.DexImport("engineGetCertPathEncodings", "()Ljava/util/Iterator;", AccessFlags = 1, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
				public virtual global::Java.Util.IIterator<string> EngineGetCertPathEncodings() /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.IIterator<string>);
				}

		}

		/// <java-name>
		/// java/security/cert/CertificateNotYetValidException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateNotYetValidException", AccessFlags = 33)]
		public partial class CertificateNotYetValidException : global::Java.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateNotYetValidException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateNotYetValidException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/cert/CertificateParsingException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertificateParsingException", AccessFlags = 33)]
		public partial class CertificateParsingException : global::Java.Security.Cert.CertificateException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertificateParsingException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertificateParsingException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateParsingException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertificateParsingException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/cert/CertPath
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPath", AccessFlags = 1057)]
		public abstract partial class CertPath : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal CertPath(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "(Ljava/lang/String;)[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetEncoded(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "(Ljava/lang/String;)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public abstract byte[] GetEncoded(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// writeReplace
				/// </java-name>
				[Dot42.DexImport("writeReplace", "()Ljava/lang/Object;", AccessFlags = 4)]
				protected internal virtual object WriteReplace() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CertPath() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public virtual string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCertificates
				/// </java-name>
				public abstract global::Java.Util.IList<global::Java.Security.Cert.Certificate> Certificates
				{
						[Dot42.DexImport("getCertificates", "()Ljava/util/List;", AccessFlags = 1025, Signature = "()Ljava/util/List<+Ljava/security/cert/Certificate;>;")]
						get;
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public abstract byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				/// <java-name>
				/// getEncodings
				/// </java-name>
				public abstract global::Java.Util.IIterator<string> Encodings
				{
						[Dot42.DexImport("getEncodings", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<Ljava/lang/String;>;")]
						get;
				}

				/// <java-name>
				/// java/security/cert/CertPath$CertPathRep
				/// </java-name>
				[Dot42.DexImport("java/security/cert/CertPath$CertPathRep", AccessFlags = 12)]
				protected internal partial class CertPathRep : global::Java.IO.ISerializable
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "(Ljava/lang/String;[B)V", AccessFlags = 4)]
						protected internal CertPathRep(string @string, sbyte[] sByte) /* MethodBuilder.Create */ 
						{
						}

						[Dot42.DexImport("<init>", "(Ljava/lang/String;[B)V", AccessFlags = 4, IgnoreFromJava = true)]
						protected internal CertPathRep(string @string, byte[] @byte) /* MethodBuilder.Create */ 
						{
						}

						/// <java-name>
						/// readResolve
						/// </java-name>
						[Dot42.DexImport("readResolve", "()Ljava/lang/Object;", AccessFlags = 4)]
						protected internal virtual object ReadResolve() /* MethodBuilder.Create */ 
						{
								return default(object);
						}

						[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
						internal CertPathRep() /* TypeBuilder.AddDefaultConstructor */ 
						{
						}

				}

		}

		/// <java-name>
		/// java/security/cert/CertPathBuilder
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathBuilder", AccessFlags = 33)]
		public partial class CertPathBuilder
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertPathBuilderSpi;Ljava/security/Provider;Ljava/lang/String" +
    ";)V", AccessFlags = 4)]
				protected internal CertPathBuilder(global::Java.Security.Cert.CertPathBuilderSpi certPathBuilderSpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertPathBuilder;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathBuilder GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathBuilder);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertPathBuilder;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathBuilder GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathBuilder);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertPathBuilder;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathBuilder GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathBuilder);
				}

				/// <java-name>
				/// build
				/// </java-name>
				[Dot42.DexImport("build", "(Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathBuilderResul" +
    "t;", AccessFlags = 17)]
				public global::Java.Security.Cert.ICertPathBuilderResult Build(global::Java.Security.Cert.ICertPathParameters certPathParameters) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.ICertPathBuilderResult);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CertPathBuilder() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <java-name>
				/// getDefaultType
				/// </java-name>
				public static string DefaultType
				{
						[Dot42.DexImport("getDefaultType", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/security/cert/CertPathBuilderException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathBuilderException", AccessFlags = 33)]
		public partial class CertPathBuilderException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertPathBuilderException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertPathBuilderException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertPathBuilderException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertPathBuilderException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/cert/CertPathBuilderSpi
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathBuilderSpi", AccessFlags = 1057)]
		public abstract partial class CertPathBuilderSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertPathBuilderSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineBuild
				/// </java-name>
				[Dot42.DexImport("engineBuild", "(Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathBuilderResul" +
    "t;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.ICertPathBuilderResult EngineBuild(global::Java.Security.Cert.ICertPathParameters certPathParameters) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/cert/CertPathValidator
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathValidator", AccessFlags = 33)]
		public partial class CertPathValidator
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertPathValidatorSpi;Ljava/security/Provider;Ljava/lang/Stri" +
    "ng;)V", AccessFlags = 4)]
				protected internal CertPathValidator(global::Java.Security.Cert.CertPathValidatorSpi certPathValidatorSpi, global::Java.Security.Provider provider, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertPathValidator;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathValidator GetInstance(string @string) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathValidator);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertPathValidator;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathValidator GetInstance(string @string, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathValidator);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertPathValidator" +
    ";", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertPathValidator GetInstance(string @string, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertPathValidator);
				}

				/// <java-name>
				/// validate
				/// </java-name>
				[Dot42.DexImport("validate", "(Ljava/security/cert/CertPath;Ljava/security/cert/CertPathParameters;)Ljava/secur" +
    "ity/cert/CertPathValidatorResult;", AccessFlags = 17)]
				public global::Java.Security.Cert.ICertPathValidatorResult Validate(global::Java.Security.Cert.CertPath certPath, global::Java.Security.Cert.ICertPathParameters certPathParameters) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.ICertPathValidatorResult);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CertPathValidator() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getAlgorithm
				/// </java-name>
				public string Algorithm
				{
						[Dot42.DexImport("getAlgorithm", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <java-name>
				/// getDefaultType
				/// </java-name>
				public static string DefaultType
				{
						[Dot42.DexImport("getDefaultType", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/security/cert/CertPathValidatorException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathValidatorException", AccessFlags = 33)]
		public partial class CertPathValidatorException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/security/cert/CertPath;I)V", AccessFlags = 1)]
				public CertPathValidatorException(string @string, global::System.Exception exception, global::Java.Security.Cert.CertPath certPath, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertPathValidatorException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertPathValidatorException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertPathValidatorException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertPathValidatorException() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getCertPath
				/// </java-name>
				public virtual global::Java.Security.Cert.CertPath CertPath
				{
						[Dot42.DexImport("getCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.CertPath); }
				}

				/// <java-name>
				/// getIndex
				/// </java-name>
				public virtual int Index
				{
						[Dot42.DexImport("getIndex", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

		}

		/// <java-name>
		/// java/security/cert/CertPathValidatorSpi
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathValidatorSpi", AccessFlags = 1057)]
		public abstract partial class CertPathValidatorSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertPathValidatorSpi() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineValidate
				/// </java-name>
				[Dot42.DexImport("engineValidate", "(Ljava/security/cert/CertPath;Ljava/security/cert/CertPathParameters;)Ljava/secur" +
    "ity/cert/CertPathValidatorResult;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.ICertPathValidatorResult EngineValidate(global::Java.Security.Cert.CertPath certPath, global::Java.Security.Cert.ICertPathParameters certPathParameters) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/cert/CertStore
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertStore", AccessFlags = 33)]
		public partial class CertStore
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertStoreSpi;Ljava/security/Provider;Ljava/lang/String;Ljava" +
    "/security/cert/CertStoreParameters;)V", AccessFlags = 4)]
				protected internal CertStore(global::Java.Security.Cert.CertStoreSpi certStoreSpi, global::Java.Security.Provider provider, string @string, global::Java.Security.Cert.ICertStoreParameters certStoreParameters) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;)Ljava/security/cert/C" +
    "ertStore;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertStore GetInstance(string @string, global::Java.Security.Cert.ICertStoreParameters certStoreParameters) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertStore);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;Ljava/lang/String;)Lja" +
    "va/security/cert/CertStore;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertStore GetInstance(string @string, global::Java.Security.Cert.ICertStoreParameters certStoreParameters, string string1) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertStore);
				}

				/// <java-name>
				/// getInstance
				/// </java-name>
				[Dot42.DexImport("getInstance", "(Ljava/lang/String;Ljava/security/cert/CertStoreParameters;Ljava/security/Provide" +
    "r;)Ljava/security/cert/CertStore;", AccessFlags = 9)]
				public static global::Java.Security.Cert.CertStore GetInstance(string @string, global::Java.Security.Cert.ICertStoreParameters certStoreParameters, global::Java.Security.Provider provider) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.CertStore);
				}

				/// <java-name>
				/// getCertificates
				/// </java-name>
				[Dot42.DexImport("getCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;", AccessFlags = 17, Signature = "(Ljava/security/cert/CertSelector;)Ljava/util/Collection<+Ljava/security/cert/Cer" +
    "tificate;>;")]
				public global::Java.Util.ICollection<global::Java.Security.Cert.Certificate> GetCertificates(global::Java.Security.Cert.ICertSelector certSelector) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::Java.Security.Cert.Certificate>);
				}

				/// <java-name>
				/// getCRLs
				/// </java-name>
				[Dot42.DexImport("getCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;", AccessFlags = 17, Signature = "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection<+Ljava/security/cert/CRL;" +
    ">;")]
				public global::Java.Util.ICollection<global::Java.Security.Cert.CRL> GetCRLs(global::Java.Security.Cert.ICRLSelector cRLSelector) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Util.ICollection<global::Java.Security.Cert.CRL>);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CertStore() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getProvider
				/// </java-name>
				public global::Java.Security.Provider Provider
				{
						[Dot42.DexImport("getProvider", "()Ljava/security/Provider;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Provider); }
				}

				/// <java-name>
				/// getCertStoreParameters
				/// </java-name>
				public global::Java.Security.Cert.ICertStoreParameters CertStoreParameters
				{
						[Dot42.DexImport("getCertStoreParameters", "()Ljava/security/cert/CertStoreParameters;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Cert.ICertStoreParameters); }
				}

				/// <java-name>
				/// getDefaultType
				/// </java-name>
				public static string DefaultType
				{
						[Dot42.DexImport("getDefaultType", "()Ljava/lang/String;", AccessFlags = 25)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/security/cert/CertStoreException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertStoreException", AccessFlags = 33)]
		public partial class CertStoreException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertStoreException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CertStoreException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CertStoreException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CertStoreException() /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/cert/CertStoreSpi
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertStoreSpi", AccessFlags = 1057)]
		public abstract partial class CertStoreSpi
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertStoreParameters;)V", AccessFlags = 1)]
				public CertStoreSpi(global::Java.Security.Cert.ICertStoreParameters certStoreParameters) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// engineGetCertificates
				/// </java-name>
				[Dot42.DexImport("engineGetCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;", AccessFlags = 1025, Signature = "(Ljava/security/cert/CertSelector;)Ljava/util/Collection<+Ljava/security/cert/Cer" +
    "tificate;>;")]
				public abstract global::Java.Util.ICollection<global::Java.Security.Cert.Certificate> EngineGetCertificates(global::Java.Security.Cert.ICertSelector certSelector) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// engineGetCRLs
				/// </java-name>
				[Dot42.DexImport("engineGetCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;", AccessFlags = 1025, Signature = "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection<+Ljava/security/cert/CRL;" +
    ">;")]
				public abstract global::Java.Util.ICollection<global::Java.Security.Cert.CRL> EngineGetCRLs(global::Java.Security.Cert.ICRLSelector cRLSelector) /* MethodBuilder.Create */ ;

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CertStoreSpi() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

		}

		/// <java-name>
		/// java/security/cert/CollectionCertStoreParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CollectionCertStoreParameters", AccessFlags = 33)]
		public partial class CollectionCertStoreParameters : global::Java.Security.Cert.ICertStoreParameters
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CollectionCertStoreParameters() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)V")]
				public CollectionCertStoreParameters(global::Java.Util.ICollection<object> collection) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getCollection
				/// </java-name>
				public virtual global::Java.Util.ICollection<object> Collection
				{
						[Dot42.DexImport("getCollection", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<*>;")]
						get{ return default(global::Java.Util.ICollection<object>); }
				}

		}

		/// <java-name>
		/// java/security/cert/CRL
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CRL", AccessFlags = 1057)]
		public abstract partial class CRL
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 4)]
				protected internal CRL(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// isRevoked
				/// </java-name>
				[Dot42.DexImport("isRevoked", "(Ljava/security/cert/Certificate;)Z", AccessFlags = 1025)]
				public abstract bool IsRevoked(global::Java.Security.Cert.Certificate certificate) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal CRL() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getType
				/// </java-name>
				public string Type
				{
						[Dot42.DexImport("getType", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/security/cert/CRLException
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CRLException", AccessFlags = 33)]
		public partial class CRLException : global::Java.Security.GeneralSecurityException
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public CRLException(string @string) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public CRLException() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CRLException(string @string, global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/Throwable;)V", AccessFlags = 1)]
				public CRLException(global::System.Exception exception) /* MethodBuilder.Create */ 
				{
				}

		}

		/// <java-name>
		/// java/security/cert/CertPathBuilderResult
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathBuilderResult", AccessFlags = 1537)]
		public partial interface ICertPathBuilderResult : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCertPath
				/// </java-name>
				global::Java.Security.Cert.CertPath CertPath
				{
						[Dot42.DexImport("getCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/cert/CertPathParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathParameters", AccessFlags = 1537)]
		public partial interface ICertPathParameters : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/cert/CertPathValidatorResult
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertPathValidatorResult", AccessFlags = 1537)]
		public partial interface ICertPathValidatorResult : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/cert/CertSelector
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertSelector", AccessFlags = 1537)]
		public partial interface ICertSelector : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/security/cert/Certificate;)Z", AccessFlags = 1025)]
				bool Match(global::Java.Security.Cert.Certificate certificate) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/cert/CertStoreParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CertStoreParameters", AccessFlags = 1537)]
		public partial interface ICertStoreParameters : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/cert/CRLSelector
		/// </java-name>
		[Dot42.DexImport("java/security/cert/CRLSelector", AccessFlags = 1537)]
		public partial interface ICRLSelector : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				object Clone() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/security/cert/CRL;)Z", AccessFlags = 1025)]
				bool Match(global::Java.Security.Cert.CRL cRL) /* MethodBuilder.Create */ ;

		}

		/// <java-name>
		/// java/security/cert/PolicyNode
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PolicyNode", AccessFlags = 1537)]
		public partial interface IPolicyNode
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getChildren
				/// </java-name>
				global::Java.Util.IIterator<global::Java.Security.Cert.IPolicyNode> Children
				{
						[Dot42.DexImport("getChildren", "()Ljava/util/Iterator;", AccessFlags = 1025, Signature = "()Ljava/util/Iterator<+Ljava/security/cert/PolicyNode;>;")]
						get;
				}

				/// <java-name>
				/// getDepth
				/// </java-name>
				int Depth
				{
						[Dot42.DexImport("getDepth", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getExpectedPolicies
				/// </java-name>
				global::Java.Util.ISet<string> ExpectedPolicies
				{
						[Dot42.DexImport("getExpectedPolicies", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get;
				}

				/// <java-name>
				/// getParent
				/// </java-name>
				global::Java.Security.Cert.IPolicyNode Parent
				{
						[Dot42.DexImport("getParent", "()Ljava/security/cert/PolicyNode;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getPolicyQualifiers
				/// </java-name>
				global::Java.Util.ISet<global::Java.Security.Cert.PolicyQualifierInfo> PolicyQualifiers
				{
						[Dot42.DexImport("getPolicyQualifiers", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<+Ljava/security/cert/PolicyQualifierInfo;>;")]
						get;
				}

				/// <java-name>
				/// getValidPolicy
				/// </java-name>
				string ValidPolicy
				{
						[Dot42.DexImport("getValidPolicy", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// isCritical
				/// </java-name>
				bool IsCritical
				{
						[Dot42.DexImport("isCritical", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/cert/X509Extension
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509Extension", AccessFlags = 1537)]
		public partial interface IX509Extension
 /* scope: __dot42__ */ 
		{
				/// <java-name>
				/// getExtensionValue
				/// </java-name>
				[Dot42.DexImport("getExtensionValue", "(Ljava/lang/String;)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				byte[] GetExtensionValue(string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getCriticalExtensionOIDs
				/// </java-name>
				global::Java.Util.ISet<string> CriticalExtensionOIDs
				{
						[Dot42.DexImport("getCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get;
				}

				/// <java-name>
				/// getNonCriticalExtensionOIDs
				/// </java-name>
				global::Java.Util.ISet<string> NonCriticalExtensionOIDs
				{
						[Dot42.DexImport("getNonCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get;
				}

				/// <java-name>
				/// hasUnsupportedCriticalExtension
				/// </java-name>
				bool HasUnsupportedCriticalExtension
				{
						[Dot42.DexImport("hasUnsupportedCriticalExtension", "()Z", AccessFlags = 1025)]
						get;
				}

		}

		/// <java-name>
		/// java/security/cert/LDAPCertStoreParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/LDAPCertStoreParameters", AccessFlags = 33)]
		public partial class LDAPCertStoreParameters : global::Java.Security.Cert.ICertStoreParameters
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/lang/String;I)V", AccessFlags = 1)]
				public LDAPCertStoreParameters(string @string, int int32) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public LDAPCertStoreParameters() /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public LDAPCertStoreParameters(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// getPort
				/// </java-name>
				public virtual int Port
				{
						[Dot42.DexImport("getPort", "()I", AccessFlags = 1)]
						get{ return default(int); }
				}

				/// <java-name>
				/// getServerName
				/// </java-name>
				public virtual string ServerName
				{
						[Dot42.DexImport("getServerName", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

		}

		/// <java-name>
		/// java/security/cert/PKIXBuilderParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PKIXBuilderParameters", AccessFlags = 33)]
		public partial class PKIXBuilderParameters : global::Java.Security.Cert.PKIXParameters
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/Set;Ljava/security/cert/CertSelector;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/security/cert/TrustAnchor;>;Ljava/security/cert/CertSelecto" +
    "r;)V")]
				public PKIXBuilderParameters(global::Java.Util.ISet<global::Java.Security.Cert.TrustAnchor> set, global::Java.Security.Cert.ICertSelector certSelector) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore;Ljava/security/cert/CertSelector;)V", AccessFlags = 1)]
				public PKIXBuilderParameters(global::Java.Security.KeyStore keyStore, global::Java.Security.Cert.ICertSelector certSelector) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PKIXBuilderParameters() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getMaxPathLength
				/// </java-name>
				public virtual int MaxPathLength
				{
						[Dot42.DexImport("getMaxPathLength", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setMaxPathLength", "(I)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/security/cert/PKIXCertPathBuilderResult
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PKIXCertPathBuilderResult", AccessFlags = 33)]
		public partial class PKIXCertPathBuilderResult : global::Java.Security.Cert.PKIXCertPathValidatorResult, global::Java.Security.Cert.ICertPathBuilderResult
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/cert/CertPath;Ljava/security/cert/TrustAnchor;Ljava/security/cert" +
    "/PolicyNode;Ljava/security/PublicKey;)V", AccessFlags = 1)]
				public PKIXCertPathBuilderResult(global::Java.Security.Cert.CertPath certPath, global::Java.Security.Cert.TrustAnchor trustAnchor, global::Java.Security.Cert.IPolicyNode policyNode, global::Java.Security.IPublicKey publicKey) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PKIXCertPathBuilderResult() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				[Dot42.DexImport("java/security/cert/CertPathBuilderResult", "clone", "()Ljava/lang/Object;", AccessFlags = 1025)]
				public override object Clone() /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getCertPath
				/// </java-name>
				public virtual global::Java.Security.Cert.CertPath CertPath
				{
						[Dot42.DexImport("getCertPath", "()Ljava/security/cert/CertPath;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.CertPath); }
				}

		}

		/// <java-name>
		/// java/security/cert/PKIXCertPathChecker
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PKIXCertPathChecker", AccessFlags = 1057)]
		public abstract partial class PKIXCertPathChecker : global::Java.Lang.ICloneable
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal PKIXCertPathChecker() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// init
				/// </java-name>
				[Dot42.DexImport("init", "(Z)V", AccessFlags = 1025)]
				public abstract void Init(bool boolean) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// check
				/// </java-name>
				[Dot42.DexImport("check", "(Ljava/security/cert/Certificate;Ljava/util/Collection;)V", AccessFlags = 1025, Signature = "(Ljava/security/cert/Certificate;Ljava/util/Collection<Ljava/lang/String;>;)V")]
				public abstract void Check(global::Java.Security.Cert.Certificate certificate, global::Java.Util.ICollection<string> collection) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// isForwardCheckingSupported
				/// </java-name>
				public abstract bool IsForwardCheckingSupported
				{
						[Dot42.DexImport("isForwardCheckingSupported", "()Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSupportedExtensions
				/// </java-name>
				public abstract global::Java.Util.ISet<string> SupportedExtensions
				{
						[Dot42.DexImport("getSupportedExtensions", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get;
				}

		}

		/// <java-name>
		/// java/security/cert/PKIXCertPathValidatorResult
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PKIXCertPathValidatorResult", AccessFlags = 33)]
		public partial class PKIXCertPathValidatorResult : global::Java.Security.Cert.ICertPathValidatorResult
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/cert/TrustAnchor;Ljava/security/cert/PolicyNode;Ljava/security/Pu" +
    "blicKey;)V", AccessFlags = 1)]
				public PKIXCertPathValidatorResult(global::Java.Security.Cert.TrustAnchor trustAnchor, global::Java.Security.Cert.IPolicyNode policyNode, global::Java.Security.IPublicKey publicKey) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PKIXCertPathValidatorResult() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getPolicyTree
				/// </java-name>
				public virtual global::Java.Security.Cert.IPolicyNode PolicyTree
				{
						[Dot42.DexImport("getPolicyTree", "()Ljava/security/cert/PolicyNode;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.IPolicyNode); }
				}

				/// <java-name>
				/// getPublicKey
				/// </java-name>
				public virtual global::Java.Security.IPublicKey PublicKey
				{
						[Dot42.DexImport("getPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1)]
						get{ return default(global::Java.Security.IPublicKey); }
				}

				/// <java-name>
				/// getTrustAnchor
				/// </java-name>
				public virtual global::Java.Security.Cert.TrustAnchor TrustAnchor
				{
						[Dot42.DexImport("getTrustAnchor", "()Ljava/security/cert/TrustAnchor;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.TrustAnchor); }
				}

		}

		/// <java-name>
		/// java/security/cert/PKIXParameters
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PKIXParameters", AccessFlags = 33)]
		public partial class PKIXParameters : global::Java.Security.Cert.ICertPathParameters
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/security/cert/TrustAnchor;>;)V")]
				public PKIXParameters(global::Java.Util.ISet<global::Java.Security.Cert.TrustAnchor> set) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/KeyStore;)V", AccessFlags = 1)]
				public PKIXParameters(global::Java.Security.KeyStore keyStore) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addCertPathChecker
				/// </java-name>
				[Dot42.DexImport("addCertPathChecker", "(Ljava/security/cert/PKIXCertPathChecker;)V", AccessFlags = 1)]
				public virtual void AddCertPathChecker(global::Java.Security.Cert.PKIXCertPathChecker pKIXCertPathChecker) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addCertStore
				/// </java-name>
				[Dot42.DexImport("addCertStore", "(Ljava/security/cert/CertStore;)V", AccessFlags = 1)]
				public virtual void AddCertStore(global::Java.Security.Cert.CertStore certStore) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PKIXParameters() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getTrustAnchors
				/// </java-name>
				public virtual global::Java.Util.ISet<global::Java.Security.Cert.TrustAnchor> TrustAnchors
				{
						[Dot42.DexImport("getTrustAnchors", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/security/cert/TrustAnchor;>;")]
						get{ return default(global::Java.Util.ISet<global::Java.Security.Cert.TrustAnchor>); }
						[Dot42.DexImport("setTrustAnchors", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/security/cert/TrustAnchor;>;)V")]
						set{ }
				}

				/// <java-name>
				/// isAnyPolicyInhibited
				/// </java-name>
				public virtual bool IsAnyPolicyInhibited
				{
						[Dot42.DexImport("isAnyPolicyInhibited", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setAnyPolicyInhibited", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCertPathCheckers
				/// </java-name>
				public virtual global::Java.Util.IList<global::Java.Security.Cert.PKIXCertPathChecker> CertPathCheckers
				{
						[Dot42.DexImport("getCertPathCheckers", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/security/cert/PKIXCertPathChecker;>;")]
						get{ return default(global::Java.Util.IList<global::Java.Security.Cert.PKIXCertPathChecker>); }
						[Dot42.DexImport("setCertPathCheckers", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Ljava/security/cert/PKIXCertPathChecker;>;)V")]
						set{ }
				}

				/// <java-name>
				/// getCertStores
				/// </java-name>
				public virtual global::Java.Util.IList<global::Java.Security.Cert.CertStore> CertStores
				{
						[Dot42.DexImport("getCertStores", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/security/cert/CertStore;>;")]
						get{ return default(global::Java.Util.IList<global::Java.Security.Cert.CertStore>); }
						[Dot42.DexImport("setCertStores", "(Ljava/util/List;)V", AccessFlags = 1, Signature = "(Ljava/util/List<Ljava/security/cert/CertStore;>;)V")]
						set{ }
				}

				/// <java-name>
				/// getDate
				/// </java-name>
				public virtual global::Java.Util.Date Date
				{
						[Dot42.DexImport("getDate", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Date); }
						[Dot42.DexImport("setDate", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isExplicitPolicyRequired
				/// </java-name>
				public virtual bool IsExplicitPolicyRequired
				{
						[Dot42.DexImport("isExplicitPolicyRequired", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setExplicitPolicyRequired", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getInitialPolicies
				/// </java-name>
				public virtual global::Java.Util.ISet<string> InitialPolicies
				{
						[Dot42.DexImport("getInitialPolicies", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
						[Dot42.DexImport("setInitialPolicies", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/lang/String;>;)V")]
						set{ }
				}

				/// <java-name>
				/// isPolicyMappingInhibited
				/// </java-name>
				public virtual bool IsPolicyMappingInhibited
				{
						[Dot42.DexImport("isPolicyMappingInhibited", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setPolicyMappingInhibited", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPolicyQualifiersRejected
				/// </java-name>
				public virtual bool IsPolicyQualifiersRejected
				{
						[Dot42.DexImport("getPolicyQualifiersRejected", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setPolicyQualifiersRejected", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// isRevocationEnabled
				/// </java-name>
				public virtual bool IsRevocationEnabled
				{
						[Dot42.DexImport("isRevocationEnabled", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setRevocationEnabled", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSigProvider
				/// </java-name>
				public virtual string SigProvider
				{
						[Dot42.DexImport("getSigProvider", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSigProvider", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getTargetCertConstraints
				/// </java-name>
				public virtual global::Java.Security.Cert.ICertSelector TargetCertConstraints
				{
						[Dot42.DexImport("getTargetCertConstraints", "()Ljava/security/cert/CertSelector;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.ICertSelector); }
						[Dot42.DexImport("setTargetCertConstraints", "(Ljava/security/cert/CertSelector;)V", AccessFlags = 1)]
						set{ }
				}

		}

		/// <java-name>
		/// java/security/cert/PolicyQualifierInfo
		/// </java-name>
		[Dot42.DexImport("java/security/cert/PolicyQualifierInfo", AccessFlags = 33)]
		public partial class PolicyQualifierInfo
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1)]
				public PolicyQualifierInfo(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public PolicyQualifierInfo(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// getPolicyQualifier
				/// </java-name>
				[Dot42.DexImport("getPolicyQualifier", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGetPolicyQualifier() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal PolicyQualifierInfo() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getPolicyQualifierId
				/// </java-name>
				public string PolicyQualifierId
				{
						[Dot42.DexImport("getPolicyQualifierId", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getPolicyQualifier
				/// </java-name>
				public byte[] PolicyQualifier
				{
						[Dot42.DexImport("getPolicyQualifier", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

		}

		/// <java-name>
		/// java/security/cert/TrustAnchor
		/// </java-name>
		[Dot42.DexImport("java/security/cert/TrustAnchor", AccessFlags = 33)]
		public partial class TrustAnchor
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "(Ljava/security/cert/X509Certificate;[B)V", AccessFlags = 1)]
				public TrustAnchor(global::Java.Security.Cert.X509Certificate x509Certificate, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/security/cert/X509Certificate;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public TrustAnchor(global::Java.Security.Cert.X509Certificate x509Certificate, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/PublicKey;[B)V", AccessFlags = 1)]
				public TrustAnchor(string @string, global::Java.Security.IPublicKey publicKey, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljava/lang/String;Ljava/security/PublicKey;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public TrustAnchor(string @string, global::Java.Security.IPublicKey publicKey, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljavax/security/auth/x500/X500Principal;Ljava/security/PublicKey;[B)V", AccessFlags = 1)]
				public TrustAnchor(global::Javax.Security.Auth.X500.X500Principal x500Principal, global::Java.Security.IPublicKey publicKey, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				[Dot42.DexImport("<init>", "(Ljavax/security/auth/x500/X500Principal;Ljava/security/PublicKey;[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public TrustAnchor(global::Javax.Security.Auth.X500.X500Principal x500Principal, global::Java.Security.IPublicKey publicKey, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNameConstraints
				/// </java-name>
				[Dot42.DexImport("getNameConstraints", "()[B", AccessFlags = 17)]
				public sbyte[] JavaGetNameConstraints() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
				internal TrustAnchor() /* TypeBuilder.AddDefaultConstructor */ 
				{
				}

				/// <java-name>
				/// getNameConstraints
				/// </java-name>
				public byte[] NameConstraints
				{
						[Dot42.DexImport("getNameConstraints", "()[B", AccessFlags = 17, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getTrustedCert
				/// </java-name>
				public global::Java.Security.Cert.X509Certificate TrustedCert
				{
						[Dot42.DexImport("getTrustedCert", "()Ljava/security/cert/X509Certificate;", AccessFlags = 17)]
						get{ return default(global::Java.Security.Cert.X509Certificate); }
				}

				/// <java-name>
				/// getCA
				/// </java-name>
				public global::Javax.Security.Auth.X500.X500Principal CA
				{
						[Dot42.DexImport("getCA", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 17)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
				}

				/// <java-name>
				/// getCAName
				/// </java-name>
				public string CAName
				{
						[Dot42.DexImport("getCAName", "()Ljava/lang/String;", AccessFlags = 17)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getCAPublicKey
				/// </java-name>
				public global::Java.Security.IPublicKey CAPublicKey
				{
						[Dot42.DexImport("getCAPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 17)]
						get{ return default(global::Java.Security.IPublicKey); }
				}

		}

		/// <java-name>
		/// java/security/cert/X509Certificate
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509Certificate", AccessFlags = 1057)]
		public abstract partial class X509Certificate : global::Java.Security.Cert.Certificate, global::Java.Security.Cert.IX509Extension
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal X509Certificate() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// checkValidity
				/// </java-name>
				[Dot42.DexImport("checkValidity", "()V", AccessFlags = 1025)]
				public abstract void CheckValidity() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// checkValidity
				/// </java-name>
				[Dot42.DexImport("checkValidity", "(Ljava/util/Date;)V", AccessFlags = 1025)]
				public abstract void CheckValidity(global::Java.Util.Date date) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getTBSCertificate
				/// </java-name>
				[Dot42.DexImport("getTBSCertificate", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetTBSCertificate() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSignature
				/// </java-name>
				[Dot42.DexImport("getSignature", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetSignature() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSigAlgParams
				/// </java-name>
				[Dot42.DexImport("getSigAlgParams", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetSigAlgParams() /* MethodBuilder.Create */ ;

				[Dot42.DexImport("java/security/cert/X509Extension", "getExtensionValue", "(Ljava/lang/String;)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public virtual byte[] GetExtensionValue(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public abstract int Version
				{
						[Dot42.DexImport("getVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				public abstract global::Java.Math.BigInteger SerialNumber
				{
						[Dot42.DexImport("getSerialNumber", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getIssuerDN
				/// </java-name>
				public abstract global::Java.Security.IPrincipal IssuerDN
				{
						[Dot42.DexImport("getIssuerDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getIssuerX500Principal
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal IssuerX500Principal
				{
						[Dot42.DexImport("getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
				}

				/// <java-name>
				/// getSubjectDN
				/// </java-name>
				public abstract global::Java.Security.IPrincipal SubjectDN
				{
						[Dot42.DexImport("getSubjectDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSubjectX500Principal
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal SubjectX500Principal
				{
						[Dot42.DexImport("getSubjectX500Principal", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
				}

				/// <java-name>
				/// getNotBefore
				/// </java-name>
				public abstract global::Java.Util.Date NotBefore
				{
						[Dot42.DexImport("getNotBefore", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNotAfter
				/// </java-name>
				public abstract global::Java.Util.Date NotAfter
				{
						[Dot42.DexImport("getNotAfter", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getTBSCertificate
				/// </java-name>
				public abstract byte[] TBSCertificate
				{
						[Dot42.DexImport("getTBSCertificate", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				/// <java-name>
				/// getSignature
				/// </java-name>
				public abstract byte[] Signature
				{
						[Dot42.DexImport("getSignature", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				/// <java-name>
				/// getSigAlgName
				/// </java-name>
				public abstract string SigAlgName
				{
						[Dot42.DexImport("getSigAlgName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSigAlgOID
				/// </java-name>
				public abstract string SigAlgOID
				{
						[Dot42.DexImport("getSigAlgOID", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSigAlgParams
				/// </java-name>
				public abstract byte[] SigAlgParams
				{
						[Dot42.DexImport("getSigAlgParams", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				/// <java-name>
				/// getIssuerUniqueID
				/// </java-name>
				public abstract bool[] IssuerUniqueID
				{
						[Dot42.DexImport("getIssuerUniqueID", "()[Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSubjectUniqueID
				/// </java-name>
				public abstract bool[] SubjectUniqueID
				{
						[Dot42.DexImport("getSubjectUniqueID", "()[Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getKeyUsage
				/// </java-name>
				public abstract bool[] KeyUsage
				{
						[Dot42.DexImport("getKeyUsage", "()[Z", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getExtendedKeyUsage
				/// </java-name>
				public virtual global::Java.Util.IList<string> ExtendedKeyUsage
				{
						[Dot42.DexImport("getExtendedKeyUsage", "()Ljava/util/List;", AccessFlags = 1, Signature = "()Ljava/util/List<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.IList<string>); }
				}

				/// <java-name>
				/// getBasicConstraints
				/// </java-name>
				public abstract int BasicConstraints
				{
						[Dot42.DexImport("getBasicConstraints", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSubjectAlternativeNames
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Java.Util.IList<object>> SubjectAlternativeNames
				{
						[Dot42.DexImport("getSubjectAlternativeNames", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/util/List<*>;>;")]
						get{ return default(global::Java.Util.ICollection<global::Java.Util.IList<object>>); }
				}

				/// <java-name>
				/// getIssuerAlternativeNames
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Java.Util.IList<object>> IssuerAlternativeNames
				{
						[Dot42.DexImport("getIssuerAlternativeNames", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/util/List<*>;>;")]
						get{ return default(global::Java.Util.ICollection<global::Java.Util.IList<object>>); }
				}

				public virtual global::Java.Util.ISet<string> CriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual global::Java.Util.ISet<string> NonCriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual bool HasUnsupportedCriticalExtension
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "hasUnsupportedCriticalExtension", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/security/cert/X509CertSelector
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509CertSelector", AccessFlags = 33)]
		public partial class X509CertSelector : global::Java.Security.Cert.ICertSelector
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public X509CertSelector() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIssuer
				/// </java-name>
				[Dot42.DexImport("setIssuer", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetIssuer(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIssuer
				/// </java-name>
				[Dot42.DexImport("setIssuer", "([B)V", AccessFlags = 1)]
				public virtual void SetIssuer(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setIssuer
				/// </java-name>
				[Dot42.DexImport("setIssuer", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetIssuer(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getIssuerAsBytes
				/// </java-name>
				[Dot42.DexImport("getIssuerAsBytes", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetIssuerAsBytes() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// setSubject
				/// </java-name>
				[Dot42.DexImport("setSubject", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void SetSubject(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSubject
				/// </java-name>
				[Dot42.DexImport("setSubject", "([B)V", AccessFlags = 1)]
				public virtual void SetSubject(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSubject
				/// </java-name>
				[Dot42.DexImport("setSubject", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetSubject(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSubjectAsBytes
				/// </java-name>
				[Dot42.DexImport("getSubjectAsBytes", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetSubjectAsBytes() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// setSubjectKeyIdentifier
				/// </java-name>
				[Dot42.DexImport("setSubjectKeyIdentifier", "([B)V", AccessFlags = 1)]
				public virtual void SetSubjectKeyIdentifier(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getSubjectKeyIdentifier
				/// </java-name>
				[Dot42.DexImport("getSubjectKeyIdentifier", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetSubjectKeyIdentifier() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// setAuthorityKeyIdentifier
				/// </java-name>
				[Dot42.DexImport("setAuthorityKeyIdentifier", "([B)V", AccessFlags = 1)]
				public virtual void SetAuthorityKeyIdentifier(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getAuthorityKeyIdentifier
				/// </java-name>
				[Dot42.DexImport("getAuthorityKeyIdentifier", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetAuthorityKeyIdentifier() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// setSubjectPublicKey
				/// </java-name>
				[Dot42.DexImport("setSubjectPublicKey", "([B)V", AccessFlags = 1)]
				public virtual void SetSubjectPublicKey(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setSubjectPublicKey
				/// </java-name>
				[Dot42.DexImport("setSubjectPublicKey", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void SetSubjectPublicKey(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addSubjectAlternativeName
				/// </java-name>
				[Dot42.DexImport("addSubjectAlternativeName", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddSubjectAlternativeName(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addSubjectAlternativeName
				/// </java-name>
				[Dot42.DexImport("addSubjectAlternativeName", "(I[B)V", AccessFlags = 1)]
				public virtual void AddSubjectAlternativeName(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addSubjectAlternativeName
				/// </java-name>
				[Dot42.DexImport("addSubjectAlternativeName", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void AddSubjectAlternativeName(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setNameConstraints
				/// </java-name>
				[Dot42.DexImport("setNameConstraints", "([B)V", AccessFlags = 1)]
				public virtual void SetNameConstraints(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// getNameConstraints
				/// </java-name>
				[Dot42.DexImport("getNameConstraints", "()[B", AccessFlags = 1)]
				public virtual sbyte[] JavaGetNameConstraints() /* MethodBuilder.Create */ 
				{
						return default(sbyte[]);
				}

				/// <java-name>
				/// addPathToName
				/// </java-name>
				[Dot42.DexImport("addPathToName", "(ILjava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddPathToName(int int32, string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPathToName
				/// </java-name>
				[Dot42.DexImport("addPathToName", "(I[B)V", AccessFlags = 1)]
				public virtual void AddPathToName(int int32, sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addPathToName
				/// </java-name>
				[Dot42.DexImport("addPathToName", "(I[B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void AddPathToName(int int32, byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/security/cert/Certificate;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Java.Security.Cert.Certificate certificate) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getCertificate
				/// </java-name>
				public virtual global::Java.Security.Cert.X509Certificate Certificate
				{
						[Dot42.DexImport("getCertificate", "()Ljava/security/cert/X509Certificate;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.X509Certificate); }
						[Dot42.DexImport("setCertificate", "(Ljava/security/cert/X509Certificate;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				public virtual global::Java.Math.BigInteger SerialNumber
				{
						[Dot42.DexImport("getSerialNumber", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
						[Dot42.DexImport("setSerialNumber", "(Ljava/math/BigInteger;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getIssuer
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal Issuer
				{
						[Dot42.DexImport("getIssuer", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
						[Dot42.DexImport("setIssuer", "(Ljavax/security/auth/x500/X500Principal;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getIssuerAsString
				/// </java-name>
				public virtual string IssuerAsString
				{
						[Dot42.DexImport("getIssuerAsString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getIssuerAsBytes
				/// </java-name>
				public virtual byte[] IssuerAsBytes
				{
						[Dot42.DexImport("getIssuerAsBytes", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getSubject
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal Subject
				{
						[Dot42.DexImport("getSubject", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
						[Dot42.DexImport("setSubject", "(Ljavax/security/auth/x500/X500Principal;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSubjectAsString
				/// </java-name>
				public virtual string SubjectAsString
				{
						[Dot42.DexImport("getSubjectAsString", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
				}

				/// <java-name>
				/// getSubjectAsBytes
				/// </java-name>
				public virtual byte[] SubjectAsBytes
				{
						[Dot42.DexImport("getSubjectAsBytes", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
				}

				/// <java-name>
				/// getSubjectKeyIdentifier
				/// </java-name>
				public virtual byte[] SubjectKeyIdentifier
				{
						[Dot42.DexImport("getSubjectKeyIdentifier", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
						[Dot42.DexImport("setSubjectKeyIdentifier", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
						set{ }
				}

				/// <java-name>
				/// getAuthorityKeyIdentifier
				/// </java-name>
				public virtual byte[] AuthorityKeyIdentifier
				{
						[Dot42.DexImport("getAuthorityKeyIdentifier", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
						[Dot42.DexImport("setAuthorityKeyIdentifier", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
						set{ }
				}

				/// <java-name>
				/// getCertificateValid
				/// </java-name>
				public virtual global::Java.Util.Date CertificateValid
				{
						[Dot42.DexImport("getCertificateValid", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Date); }
						[Dot42.DexImport("setCertificateValid", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPrivateKeyValid
				/// </java-name>
				public virtual global::Java.Util.Date PrivateKeyValid
				{
						[Dot42.DexImport("getPrivateKeyValid", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Date); }
						[Dot42.DexImport("setPrivateKeyValid", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSubjectPublicKeyAlgID
				/// </java-name>
				public virtual string SubjectPublicKeyAlgID
				{
						[Dot42.DexImport("getSubjectPublicKeyAlgID", "()Ljava/lang/String;", AccessFlags = 1)]
						get{ return default(string); }
						[Dot42.DexImport("setSubjectPublicKeyAlgID", "(Ljava/lang/String;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSubjectPublicKey
				/// </java-name>
				public virtual global::Java.Security.IPublicKey SubjectPublicKey
				{
						[Dot42.DexImport("getSubjectPublicKey", "()Ljava/security/PublicKey;", AccessFlags = 1)]
						get{ return default(global::Java.Security.IPublicKey); }
						[Dot42.DexImport("setSubjectPublicKey", "(Ljava/security/PublicKey;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getKeyUsage
				/// </java-name>
				public virtual bool[] KeyUsage
				{
						[Dot42.DexImport("getKeyUsage", "()[Z", AccessFlags = 1)]
						get{ return default(bool[]); }
						[Dot42.DexImport("setKeyUsage", "([Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getExtendedKeyUsage
				/// </java-name>
				public virtual global::Java.Util.ISet<string> ExtendedKeyUsage
				{
						[Dot42.DexImport("getExtendedKeyUsage", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
						[Dot42.DexImport("setExtendedKeyUsage", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/lang/String;>;)V")]
						set{ }
				}

				/// <java-name>
				/// getMatchAllSubjectAltNames
				/// </java-name>
				public virtual bool IsMatchAllSubjectAltNames
				{
						[Dot42.DexImport("getMatchAllSubjectAltNames", "()Z", AccessFlags = 1)]
						get{ return default(bool); }
						[Dot42.DexImport("setMatchAllSubjectAltNames", "(Z)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getSubjectAlternativeNames
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Java.Util.IList<object>> SubjectAlternativeNames
				{
						[Dot42.DexImport("getSubjectAlternativeNames", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/util/List<*>;>;")]
						get{ return default(global::Java.Util.ICollection<global::Java.Util.IList<object>>); }
						[Dot42.DexImport("setSubjectAlternativeNames", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Ljava/util/List<*>;>;)V")]
						set{ }
				}

				/// <java-name>
				/// getNameConstraints
				/// </java-name>
				public virtual byte[] NameConstraints
				{
						[Dot42.DexImport("getNameConstraints", "()[B", AccessFlags = 1, IgnoreFromJava = true)]
						get{ return default(byte[]); }
						[Dot42.DexImport("setNameConstraints", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
						set{ }
				}

				/// <java-name>
				/// getBasicConstraints
				/// </java-name>
				public virtual int BasicConstraints
				{
						[Dot42.DexImport("getBasicConstraints", "()I", AccessFlags = 1)]
						get{ return default(int); }
						[Dot42.DexImport("setBasicConstraints", "(I)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getPolicy
				/// </java-name>
				public virtual global::Java.Util.ISet<string> Policy
				{
						[Dot42.DexImport("getPolicy", "()Ljava/util/Set;", AccessFlags = 1, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
						[Dot42.DexImport("setPolicy", "(Ljava/util/Set;)V", AccessFlags = 1, Signature = "(Ljava/util/Set<Ljava/lang/String;>;)V")]
						set{ }
				}

				/// <java-name>
				/// getPathToNames
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Java.Util.IList<object>> PathToNames
				{
						[Dot42.DexImport("getPathToNames", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/util/List<*>;>;")]
						get{ return default(global::Java.Util.ICollection<global::Java.Util.IList<object>>); }
						[Dot42.DexImport("setPathToNames", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Ljava/util/List<*>;>;)V")]
						set{ }
				}

		}

		/// <java-name>
		/// java/security/cert/X509CRL
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509CRL", AccessFlags = 1057)]
		public abstract partial class X509CRL : global::Java.Security.Cert.CRL, global::Java.Security.Cert.IX509Extension
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 4)]
				protected internal X509CRL() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey publicKey) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// verify
				/// </java-name>
				[Dot42.DexImport("verify", "(Ljava/security/PublicKey;Ljava/lang/String;)V", AccessFlags = 1025)]
				public abstract void Verify(global::Java.Security.IPublicKey publicKey, string @string) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRevokedCertificate
				/// </java-name>
				[Dot42.DexImport("getRevokedCertificate", "(Ljava/math/BigInteger;)Ljava/security/cert/X509CRLEntry;", AccessFlags = 1025)]
				public abstract global::Java.Security.Cert.X509CRLEntry GetRevokedCertificate(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getRevokedCertificate
				/// </java-name>
				[Dot42.DexImport("getRevokedCertificate", "(Ljava/security/cert/X509Certificate;)Ljava/security/cert/X509CRLEntry;", AccessFlags = 1)]
				public virtual global::Java.Security.Cert.X509CRLEntry GetRevokedCertificate(global::Java.Security.Cert.X509Certificate x509Certificate) /* MethodBuilder.Create */ 
				{
						return default(global::Java.Security.Cert.X509CRLEntry);
				}

				/// <java-name>
				/// getTBSCertList
				/// </java-name>
				[Dot42.DexImport("getTBSCertList", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetTBSCertList() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSignature
				/// </java-name>
				[Dot42.DexImport("getSignature", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetSignature() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// getSigAlgParams
				/// </java-name>
				[Dot42.DexImport("getSigAlgParams", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetSigAlgParams() /* MethodBuilder.Create */ ;

				[Dot42.DexImport("java/security/cert/X509Extension", "getExtensionValue", "(Ljava/lang/String;)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public virtual byte[] GetExtensionValue(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public abstract byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				/// <java-name>
				/// getVersion
				/// </java-name>
				public abstract int Version
				{
						[Dot42.DexImport("getVersion", "()I", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getIssuerDN
				/// </java-name>
				public abstract global::Java.Security.IPrincipal IssuerDN
				{
						[Dot42.DexImport("getIssuerDN", "()Ljava/security/Principal;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getIssuerX500Principal
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal IssuerX500Principal
				{
						[Dot42.DexImport("getIssuerX500Principal", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
				}

				/// <java-name>
				/// getThisUpdate
				/// </java-name>
				public abstract global::Java.Util.Date ThisUpdate
				{
						[Dot42.DexImport("getThisUpdate", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getNextUpdate
				/// </java-name>
				public abstract global::Java.Util.Date NextUpdate
				{
						[Dot42.DexImport("getNextUpdate", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getRevokedCertificates
				/// </java-name>
				public abstract global::Java.Util.ISet<global::Java.Security.Cert.X509CRLEntry> RevokedCertificates
				{
						[Dot42.DexImport("getRevokedCertificates", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<+Ljava/security/cert/X509CRLEntry;>;")]
						get;
				}

				/// <java-name>
				/// getTBSCertList
				/// </java-name>
				public abstract byte[] TBSCertList
				{
						[Dot42.DexImport("getTBSCertList", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				/// <java-name>
				/// getSignature
				/// </java-name>
				public abstract byte[] Signature
				{
						[Dot42.DexImport("getSignature", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				/// <java-name>
				/// getSigAlgName
				/// </java-name>
				public abstract string SigAlgName
				{
						[Dot42.DexImport("getSigAlgName", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSigAlgOID
				/// </java-name>
				public abstract string SigAlgOID
				{
						[Dot42.DexImport("getSigAlgOID", "()Ljava/lang/String;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getSigAlgParams
				/// </java-name>
				public abstract byte[] SigAlgParams
				{
						[Dot42.DexImport("getSigAlgParams", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				public virtual global::Java.Util.ISet<string> CriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual global::Java.Util.ISet<string> NonCriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual bool HasUnsupportedCriticalExtension
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "hasUnsupportedCriticalExtension", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/security/cert/X509CRLEntry
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509CRLEntry", AccessFlags = 1057)]
		public abstract partial class X509CRLEntry : global::Java.Security.Cert.IX509Extension
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public X509CRLEntry() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// equals
				/// </java-name>
				[Dot42.DexImport("equals", "(Ljava/lang/Object;)Z", AccessFlags = 1)]
				public override bool Equals(object @object) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// hashCode
				/// </java-name>
				[Dot42.DexImport("hashCode", "()I", AccessFlags = 1)]
				public override int GetHashCode() /* MethodBuilder.Create */ 
				{
						return default(int);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025)]
				public abstract sbyte[] JavaGetEncoded() /* MethodBuilder.Create */ ;

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1025)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				[Dot42.DexImport("java/security/cert/X509Extension", "getExtensionValue", "(Ljava/lang/String;)[B", AccessFlags = 1025, IgnoreFromJava = true)]
				public virtual byte[] GetExtensionValue(string @string) /* TypeBuilder.AddAbstractInterfaceMethods */ 
				{
						return default(byte[]);
				}

				/// <java-name>
				/// getEncoded
				/// </java-name>
				public abstract byte[] Encoded
				{
						[Dot42.DexImport("getEncoded", "()[B", AccessFlags = 1025, IgnoreFromJava = true)]
						get;
				}

				/// <java-name>
				/// getSerialNumber
				/// </java-name>
				public abstract global::Java.Math.BigInteger SerialNumber
				{
						[Dot42.DexImport("getSerialNumber", "()Ljava/math/BigInteger;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// getCertificateIssuer
				/// </java-name>
				public virtual global::Javax.Security.Auth.X500.X500Principal CertificateIssuer
				{
						[Dot42.DexImport("getCertificateIssuer", "()Ljavax/security/auth/x500/X500Principal;", AccessFlags = 1)]
						get{ return default(global::Javax.Security.Auth.X500.X500Principal); }
				}

				/// <java-name>
				/// getRevocationDate
				/// </java-name>
				public abstract global::Java.Util.Date RevocationDate
				{
						[Dot42.DexImport("getRevocationDate", "()Ljava/util/Date;", AccessFlags = 1025)]
						get;
				}

				/// <java-name>
				/// hasExtensions
				/// </java-name>
				public abstract bool HasExtensions
				{
						[Dot42.DexImport("hasExtensions", "()Z", AccessFlags = 1025)]
						get;
				}

				public virtual global::Java.Util.ISet<string> CriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual global::Java.Util.ISet<string> NonCriticalExtensionOIDs
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "getNonCriticalExtensionOIDs", "()Ljava/util/Set;", AccessFlags = 1025, Signature = "()Ljava/util/Set<Ljava/lang/String;>;")]
						get{ return default(global::Java.Util.ISet<string>); }
				}

				public virtual bool HasUnsupportedCriticalExtension
				{
						[Dot42.DexImport("java/security/cert/X509Extension", "hasUnsupportedCriticalExtension", "()Z", AccessFlags = 1025)]
						get{ return default(bool); }
				}

		}

		/// <java-name>
		/// java/security/cert/X509CRLSelector
		/// </java-name>
		[Dot42.DexImport("java/security/cert/X509CRLSelector", AccessFlags = 33)]
		public partial class X509CRLSelector : global::Java.Security.Cert.ICRLSelector
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public X509CRLSelector() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addIssuer
				/// </java-name>
				[Dot42.DexImport("addIssuer", "(Ljavax/security/auth/x500/X500Principal;)V", AccessFlags = 1)]
				public virtual void AddIssuer(global::Javax.Security.Auth.X500.X500Principal x500Principal) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addIssuerName
				/// </java-name>
				[Dot42.DexImport("addIssuerName", "(Ljava/lang/String;)V", AccessFlags = 1)]
				public virtual void AddIssuerName(string @string) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addIssuerName
				/// </java-name>
				[Dot42.DexImport("addIssuerName", "([B)V", AccessFlags = 1)]
				public virtual void AddIssuerName(sbyte[] sByte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// addIssuerName
				/// </java-name>
				[Dot42.DexImport("addIssuerName", "([B)V", AccessFlags = 1, IgnoreFromJava = true)]
				public virtual void AddIssuerName(byte[] @byte) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMinCRLNumber
				/// </java-name>
				[Dot42.DexImport("setMinCRLNumber", "(Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public virtual void SetMinCRLNumber(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// setMaxCRLNumber
				/// </java-name>
				[Dot42.DexImport("setMaxCRLNumber", "(Ljava/math/BigInteger;)V", AccessFlags = 1)]
				public virtual void SetMaxCRLNumber(global::Java.Math.BigInteger bigInteger) /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// toString
				/// </java-name>
				[Dot42.DexImport("toString", "()Ljava/lang/String;", AccessFlags = 1)]
				public override string ToString() /* MethodBuilder.Create */ 
				{
						return default(string);
				}

				/// <java-name>
				/// match
				/// </java-name>
				[Dot42.DexImport("match", "(Ljava/security/cert/CRL;)Z", AccessFlags = 1)]
				public virtual bool Match(global::Java.Security.Cert.CRL cRL) /* MethodBuilder.Create */ 
				{
						return default(bool);
				}

				/// <java-name>
				/// clone
				/// </java-name>
				[Dot42.DexImport("clone", "()Ljava/lang/Object;", AccessFlags = 1)]
				public virtual object Clone() /* MethodBuilder.Create */ 
				{
						return default(object);
				}

				/// <java-name>
				/// getIssuers
				/// </java-name>
				public virtual global::Java.Util.ICollection<global::Javax.Security.Auth.X500.X500Principal> Issuers
				{
						[Dot42.DexImport("getIssuers", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljavax/security/auth/x500/X500Principal;>;")]
						get{ return default(global::Java.Util.ICollection<global::Javax.Security.Auth.X500.X500Principal>); }
						[Dot42.DexImport("setIssuers", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<Ljavax/security/auth/x500/X500Principal;>;)V")]
						set{ }
				}

				/// <java-name>
				/// getIssuerNames
				/// </java-name>
				public virtual global::Java.Util.ICollection<object> IssuerNames
				{
						[Dot42.DexImport("getIssuerNames", "()Ljava/util/Collection;", AccessFlags = 1, Signature = "()Ljava/util/Collection<Ljava/lang/Object;>;")]
						get{ return default(global::Java.Util.ICollection<object>); }
						[Dot42.DexImport("setIssuerNames", "(Ljava/util/Collection;)V", AccessFlags = 1, Signature = "(Ljava/util/Collection<*>;)V")]
						set{ }
				}

				/// <java-name>
				/// getMinCRL
				/// </java-name>
				public virtual global::Java.Math.BigInteger MinCRL
				{
						[Dot42.DexImport("getMinCRL", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

				/// <java-name>
				/// getMaxCRL
				/// </java-name>
				public virtual global::Java.Math.BigInteger MaxCRL
				{
						[Dot42.DexImport("getMaxCRL", "()Ljava/math/BigInteger;", AccessFlags = 1)]
						get{ return default(global::Java.Math.BigInteger); }
				}

				/// <java-name>
				/// getDateAndTime
				/// </java-name>
				public virtual global::Java.Util.Date DateAndTime
				{
						[Dot42.DexImport("getDateAndTime", "()Ljava/util/Date;", AccessFlags = 1)]
						get{ return default(global::Java.Util.Date); }
						[Dot42.DexImport("setDateAndTime", "(Ljava/util/Date;)V", AccessFlags = 1)]
						set{ }
				}

				/// <java-name>
				/// getCertificateChecking
				/// </java-name>
				public virtual global::Java.Security.Cert.X509Certificate CertificateChecking
				{
						[Dot42.DexImport("getCertificateChecking", "()Ljava/security/cert/X509Certificate;", AccessFlags = 1)]
						get{ return default(global::Java.Security.Cert.X509Certificate); }
						[Dot42.DexImport("setCertificateChecking", "(Ljava/security/cert/X509Certificate;)V", AccessFlags = 1)]
						set{ }
				}

		}

}

