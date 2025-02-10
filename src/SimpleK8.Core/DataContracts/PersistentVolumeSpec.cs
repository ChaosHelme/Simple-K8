namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PersistentVolumeSpec is the specification of a persistent volume.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PersistentVolumeSpec
{
	/// <summary>
	/// accessModes contains all ways the volume can be mounted. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes
	/// </summary>
	[Newtonsoft.Json.JsonProperty("accessModes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> AccessModes { get; set; }

	/// <summary>
	/// awsElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Deprecated: AWSElasticBlockStore is deprecated. All operations for the in-tree awsElasticBlockStore type are redirected to the ebs.csi.aws.com CSI driver. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
	/// </summary>
	[Newtonsoft.Json.JsonProperty("awsElasticBlockStore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

	/// <summary>
	/// azureDisk represents an Azure Data Disk mount on the host and bind mount to the pod. Deprecated: AzureDisk is deprecated. All operations for the in-tree azureDisk type are redirected to the disk.csi.azure.com CSI driver.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("azureDisk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public AzureDiskVolumeSource AzureDisk { get; set; }

	/// <summary>
	/// azureFile represents an Azure File Service mount on the host and bind mount to the pod. Deprecated: AzureFile is deprecated. All operations for the in-tree azureFile type are redirected to the file.csi.azure.com CSI driver.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("azureFile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public AzureFilePersistentVolumeSource AzureFile { get; set; }

	/// <summary>
	/// capacity is the description of the persistent volume's resources and capacity. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity
	/// </summary>
	[Newtonsoft.Json.JsonProperty("capacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Capacity { get; set; }

	/// <summary>
	/// cephFS represents a Ceph FS mount on the host that shares a pod's lifetime. Deprecated: CephFS is deprecated and the in-tree cephfs type is no longer supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("cephfs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CephFSPersistentVolumeSource Cephfs { get; set; }

	/// <summary>
	/// cinder represents a cinder volume attached and mounted on kubelets host machine. Deprecated: Cinder is deprecated. All operations for the in-tree cinder type are redirected to the cinder.csi.openstack.org CSI driver. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
	/// </summary>
	[Newtonsoft.Json.JsonProperty("cinder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CinderPersistentVolumeSource Cinder { get; set; }

	/// <summary>
	/// claimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim. Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding
	/// </summary>
	[Newtonsoft.Json.JsonProperty("claimRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectReference ClaimRef { get; set; }

	/// <summary>
	/// csi represents storage that is handled by an external CSI driver.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("csi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CSIPersistentVolumeSource Csi { get; set; }

	/// <summary>
	/// fc represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public FCVolumeSource Fc { get; set; }

	/// <summary>
	/// flexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin. Deprecated: FlexVolume is deprecated. Consider using a CSIDriver instead.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("flexVolume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public FlexPersistentVolumeSource FlexVolume { get; set; }

	/// <summary>
	/// flocker represents a Flocker volume attached to a kubelet's host machine and exposed to the pod for its usage. This depends on the Flocker control service being running. Deprecated: Flocker is deprecated and the in-tree flocker type is no longer supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("flocker", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public FlockerVolumeSource Flocker { get; set; }

	/// <summary>
	/// gcePersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin. Deprecated: GCEPersistentDisk is deprecated. All operations for the in-tree gcePersistentDisk type are redirected to the pd.csi.storage.gke.io CSI driver. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
	/// </summary>
	[Newtonsoft.Json.JsonProperty("gcePersistentDisk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

	/// <summary>
	/// glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod. Provisioned by an admin. Deprecated: Glusterfs is deprecated and the in-tree glusterfs type is no longer supported. More info: https://examples.k8s.io/volumes/glusterfs/README.md
	/// </summary>
	[Newtonsoft.Json.JsonProperty("glusterfs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public GlusterfsPersistentVolumeSource Glusterfs { get; set; }

	/// <summary>
	/// hostPath represents a directory on the host. Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostPath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public HostPathVolumeSource HostPath { get; set; }

	/// <summary>
	/// iscsi represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Provisioned by an admin.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("iscsi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ISCSIPersistentVolumeSource Iscsi { get; set; }

	/// <summary>
	/// local represents directly-attached storage with node affinity
	/// </summary>
	[Newtonsoft.Json.JsonProperty("local", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public LocalVolumeSource Local { get; set; }

	/// <summary>
	/// mountOptions is the list of mount options, e.g. ["ro", "soft"]. Not validated - mount will simply fail if one is invalid. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes/#mount-options
	/// </summary>
	[Newtonsoft.Json.JsonProperty("mountOptions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> MountOptions { get; set; }

	/// <summary>
	/// nfs represents an NFS mount on the host. Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nfs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NFSVolumeSource Nfs { get; set; }

	/// <summary>
	/// nodeAffinity defines constraints that limit what nodes this volume can be accessed from. This field influences the scheduling of pods that use this volume.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeAffinity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public VolumeNodeAffinity NodeAffinity { get; set; }

	/// <summary>
	/// persistentVolumeReclaimPolicy defines what happens to a persistent volume when released from its claim. Valid options are Retain (default for manually created PersistentVolumes), Delete (default for dynamically provisioned PersistentVolumes), and Recycle (deprecated). Recycle must be supported by the volume plugin underlying this PersistentVolume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming
	/// </summary>
	[Newtonsoft.Json.JsonProperty("persistentVolumeReclaimPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string PersistentVolumeReclaimPolicy { get; set; }

	/// <summary>
	/// photonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine. Deprecated: PhotonPersistentDisk is deprecated and the in-tree photonPersistentDisk type is no longer supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("photonPersistentDisk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }

	/// <summary>
	/// portworxVolume represents a portworx volume attached and mounted on kubelets host machine. Deprecated: PortworxVolume is deprecated. All operations for the in-tree portworxVolume type are redirected to the pxd.portworx.com CSI driver when the CSIMigrationPortworx feature-gate is on.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("portworxVolume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PortworxVolumeSource PortworxVolume { get; set; }

	/// <summary>
	/// quobyte represents a Quobyte mount on the host that shares a pod's lifetime. Deprecated: Quobyte is deprecated and the in-tree quobyte type is no longer supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("quobyte", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public QuobyteVolumeSource Quobyte { get; set; }

	/// <summary>
	/// rbd represents a Rados Block Device mount on the host that shares a pod's lifetime. Deprecated: RBD is deprecated and the in-tree rbd type is no longer supported. More info: https://examples.k8s.io/volumes/rbd/README.md
	/// </summary>
	[Newtonsoft.Json.JsonProperty("rbd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public RBDPersistentVolumeSource Rbd { get; set; }

	/// <summary>
	/// scaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes. Deprecated: ScaleIO is deprecated and the in-tree scaleIO type is no longer supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scaleIO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ScaleIOPersistentVolumeSource ScaleIO { get; set; }

	/// <summary>
	/// storageClassName is the name of StorageClass to which this persistent volume belongs. Empty value means that this volume does not belong to any StorageClass.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("storageClassName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string StorageClassName { get; set; }

	/// <summary>
	/// storageOS represents a StorageOS volume that is attached to the kubelet's host machine and mounted into the pod. Deprecated: StorageOS is deprecated and the in-tree storageos type is no longer supported. More info: https://examples.k8s.io/volumes/storageos/README.md
	/// </summary>
	[Newtonsoft.Json.JsonProperty("storageos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public StorageOSPersistentVolumeSource Storageos { get; set; }

	/// <summary>
	/// Name of VolumeAttributesClass to which this persistent volume belongs. Empty value is not allowed. When this field is not set, it indicates that this volume does not belong to any VolumeAttributesClass. This field is mutable and can be changed by the CSI driver after a volume has been updated successfully to a new class. For an unbound PersistentVolume, the volumeAttributesClassName will be matched with unbound PersistentVolumeClaims during the binding process. This is a beta field and requires enabling VolumeAttributesClass feature (off by default).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumeAttributesClassName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string VolumeAttributesClassName { get; set; }

	/// <summary>
	/// volumeMode defines if a volume is intended to be used with a formatted filesystem or to remain in raw block state. Value of Filesystem is implied when not included in spec.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumeMode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string VolumeMode { get; set; }

	/// <summary>
	/// vsphereVolume represents a vSphere volume attached and mounted on kubelets host machine. Deprecated: VsphereVolume is deprecated. All operations for the in-tree vsphereVolume type are redirected to the csi.vsphere.vmware.com CSI driver.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("vsphereVolume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }

}