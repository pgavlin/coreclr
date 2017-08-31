using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_guid_GuidCompareTo2_GuidCompareTo2_
    {
        [OuterLoop]
        [Fact]
        public void _system_guid_GuidCompareTo2_GuidCompareTo2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\guid\\GuidCompareTo2\\GuidCompareTo2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
