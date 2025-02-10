namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Volume represents a named volume in a pod that may be accessed by any container in the pod.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Volume
{
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
	public AzureFileVolumeSource AzureFile { get; set; }

	/// <summary>
	/// cephFS represents a Ceph FS mount on the host that shares a pod's lifetime. Deprecated: CephFS is deprecated and the in-tree cephfs type is no longer supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("cephfs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CephFSVolumeSource Cephfs { get; set; }

	/// <summary>
	/// cinder represents a cinder volume attached and mounted on kubelets host machine. Deprecated: Cinder is deprecated. All operations for the in-tree cinder type are redirected to the cinder.csi.openstack.org CSI driver. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
	/// </summary>
	[Newtonsoft.Json.JsonProperty("cinder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CinderVolumeSource Cinder { get; set; }

	/// <summary>
	/// configMap represents a configMap that should populate this volume
	/// </summary>
	[Newtonsoft.Json.JsonProperty("configMap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ConfigMapVolumeSource ConfigMap { get; set; }

	/// <summary>
	/// csi (Container Storage Interface) represents ephemeral storage that is handled by certain external CSI drivers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("csi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CSIVolumeSource Csi { get; set; }

	/// <summary>
	/// downwardAPI represents downward API about the pod that should populate this volume
	/// </summary>
	[Newtonsoft.Json.JsonProperty("downwardAPI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public DownwardAPIVolumeSource DownwardAPI { get; set; }

	/// <summary>
	/// emptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
	/// </summary>
	[Newtonsoft.Json.JsonProperty("emptyDir", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public EmptyDirVolumeSource EmptyDir { get; set; }

	/// <summary>
	/// ephemeral represents a volume that is handled by a cluster storage driver. The volume's lifecycle is tied to the pod that defines it - it will be created before the pod starts, and deleted when the pod is removed.
	/// <br/>
	/// <br/>Use this if: a) the volume is only needed while the pod runs, b) features of normal volumes like restoring from snapshot or capacity
	/// <br/>   tracking are needed,
	/// <br/>c) the storage driver is specified through a storage class, and d) the storage driver supports dynamic volume provisioning through
	/// <br/>   a PersistentVolumeClaim (see EphemeralVolumeSource for more
	/// <br/>   information on the connection between this volume type
	/// <br/>   and PersistentVolumeClaim).
	/// <br/>
	/// <br/>Use PersistentVolumeClaim or one of the vendor-specific APIs for volumes that persist for longer than the lifecycle of an individual pod.
	/// <br/>
	/// <br/>Use CSI for light-weight local ephemeral volumes if the CSI driver is meant to be used that way - see the documentation of the driver for more information.
	/// <br/>
	/// <br/>A pod can use both types of ephemeral volumes and persistent volumes at the same time.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ephemeral", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public EphemeralVolumeSource Ephemeral { get; set; }

	/// <summary>
	/// fc represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public FCVolumeSource Fc { get; set; }

	/// <summary>
	/// flexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin. Deprecated: FlexVolume is deprecated. Consider using a CSIDriver instead.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("flexVolume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public FlexVolumeSource FlexVolume { get; set; }

	/// <summary>
	/// flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running. Deprecated: Flocker is deprecated and the in-tree flocker type is no longer supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("flocker", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public FlockerVolumeSource Flocker { get; set; }

	/// <summary>
	/// gcePersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. Deprecated: GCEPersistentDisk is deprecated. All operations for the in-tree gcePersistentDisk type are redirected to the pd.csi.storage.gke.io CSI driver. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
	/// </summary>
	[Newtonsoft.Json.JsonProperty("gcePersistentDisk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

	/// <summary>
	/// gitRepo represents a git repository at a particular revision. Deprecated: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("gitRepo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public GitRepoVolumeSource GitRepo { get; set; }

	/// <summary>
	/// glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. Deprecated: Glusterfs is deprecated and the in-tree glusterfs type is no longer supported. More info: https://examples.k8s.io/volumes/glusterfs/README.md
	/// </summary>
	[Newtonsoft.Json.JsonProperty("glusterfs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public GlusterfsVolumeSource Glusterfs { get; set; }

	/// <summary>
	/// hostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostPath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public HostPathVolumeSource HostPath { get; set; }

	/// <summary>
	/// image represents an OCI object (a container image or artifact) pulled and mounted on the kubelet's host machine. The volume is resolved at pod startup depending on which PullPolicy value is provided:
	/// <br/>
	/// <br/>- Always: the kubelet always attempts to pull the reference. Container creation will fail If the pull fails. - Never: the kubelet never pulls the reference and only uses a local image or artifact. Container creation will fail if the reference isn't present. - IfNotPresent: the kubelet pulls if the reference isn't already present on disk. Container creation will fail if the reference isn't present and the pull fails.
	/// <br/>
	/// <br/>The volume gets re-resolved if the pod gets deleted and recreated, which means that new remote content will become available on pod recreation. A failure to resolve or pull the image during pod startup will block containers from starting and may add significant latency. Failures will be retried using normal volume backoff and will be reported on the pod reason and message. The types of objects that may be mounted by this volume are defined by the container runtime implementation on a host machine and at minimum must include all valid types supported by the container image field. The OCI object gets mounted in a single directory (spec.containers[*].volumeMounts.mountPath) by merging the manifest layers in the same way as for container images. The volume will be mounted read-only (ro) and non-executable files (noexec). Sub path mounts for containers are not supported (spec.containers[*].volumeMounts.subpath). The field spec.securityContext.fsGroupChangePolicy has no effect on this volume type.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("image", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ImageVolumeSource Image { get; set; }

	/// <summary>
	/// iscsi represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://examples.k8s.io/volumes/iscsi/README.md
	/// </summary>
	[Newtonsoft.Json.JsonProperty("iscsi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ISCSIVolumeSource Iscsi { get; set; }

	/// <summary>
	/// name of the volume. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// nfs represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nfs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NFSVolumeSource Nfs { get; set; }

	/// <summary>
	/// persistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
	/// </summary>
	[Newtonsoft.Json.JsonProperty("persistentVolumeClaim", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PersistentVolumeClaimVolumeSource PersistentVolumeClaim { get; set; }

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
	/// projected items for all in one resources secrets, configmaps, and downward API
	/// </summary>
	[Newtonsoft.Json.JsonProperty("projected", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ProjectedVolumeSource Projected { get; set; }

	/// <summary>
	/// quobyte represents a Quobyte mount on the host that shares a pod's lifetime. Deprecated: Quobyte is deprecated and the in-tree quobyte type is no longer supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("quobyte", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public QuobyteVolumeSource Quobyte { get; set; }

	/// <summary>
	/// rbd represents a Rados Block Device mount on the host that shares a pod's lifetime. Deprecated: RBD is deprecated and the in-tree rbd type is no longer supported. More info: https://examples.k8s.io/volumes/rbd/README.md
	/// </summary>
	[Newtonsoft.Json.JsonProperty("rbd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public RBDVolumeSource Rbd { get; set; }

	/// <summary>
	/// scaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes. Deprecated: ScaleIO is deprecated and the in-tree scaleIO type is no longer supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scaleIO", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ScaleIOVolumeSource ScaleIO { get; set; }

	/// <summary>
	/// secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
	/// </summary>
	[Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SecretVolumeSource Secret { get; set; }

	/// <summary>
	/// storageOS represents a StorageOS volume attached and mounted on Kubernetes nodes. Deprecated: StorageOS is deprecated and the in-tree storageos type is no longer supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("storageos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public StorageOSVolumeSource Storageos { get; set; }

	/// <summary>
	/// vsphereVolume represents a vSphere volume attached and mounted on kubelets host machine. Deprecated: VsphereVolume is deprecated. All operations for the in-tree vsphereVolume type are redirected to the csi.vsphere.vmware.com CSI driver.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("vsphereVolume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }

}