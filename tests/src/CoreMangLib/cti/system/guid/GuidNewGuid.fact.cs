using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_guid_GuidNewGuid_GuidNewGuid_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidNewGuid_GuidNewGuid_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidNewGuid\\GuidNewGuid.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
