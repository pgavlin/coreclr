using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint32_UInt32MinValue_UInt32MinValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint32_UInt32MinValue_UInt32MinValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint32\\UInt32MinValue\\UInt32MinValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
