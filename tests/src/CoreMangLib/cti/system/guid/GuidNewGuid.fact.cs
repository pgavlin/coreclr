using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_guid_GuidNewGuid_GuidNewGuid_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidNewGuid_GuidNewGuid_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidNewGuid\\GuidNewGuid.cmd");
        }
    }
}
