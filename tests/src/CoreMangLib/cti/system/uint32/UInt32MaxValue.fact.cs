using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32MaxValue_UInt32MaxValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32MaxValue_UInt32MaxValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32MaxValue\\UInt32MaxValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
