using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_guid_GuidCompareTo1_cti_GuidCompareTo1_cti_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidCompareTo1_cti_GuidCompareTo1_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidCompareTo1_cti\\GuidCompareTo1_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
