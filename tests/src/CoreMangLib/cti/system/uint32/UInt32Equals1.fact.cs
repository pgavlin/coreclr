using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32Equals1_UInt32Equals1_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32Equals1_UInt32Equals1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32Equals1\\UInt32Equals1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
