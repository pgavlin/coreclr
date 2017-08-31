using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_uint16_UInt16IConvertibleToInt64_UInt16IConvertibleToInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_uint16_UInt16IConvertibleToInt64_UInt16IConvertibleToInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\uint16\\UInt16IConvertibleToInt64\\UInt16IConvertibleToInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
