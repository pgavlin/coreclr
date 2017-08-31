using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt169_ConvertToUInt169_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt169_ConvertToUInt169_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt169\\ConvertToUInt169.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
