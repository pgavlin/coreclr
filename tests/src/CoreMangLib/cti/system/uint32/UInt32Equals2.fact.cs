using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32Equals2_UInt32Equals2_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32Equals2_UInt32Equals2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32Equals2\\UInt32Equals2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
