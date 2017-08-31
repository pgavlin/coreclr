using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_guid_GuidEquals1_cti_GuidEquals1_cti_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidEquals1_cti_GuidEquals1_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidEquals1_cti\\GuidEquals1_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
