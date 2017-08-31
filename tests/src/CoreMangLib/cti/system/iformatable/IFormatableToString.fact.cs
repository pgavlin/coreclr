using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_iformatable_IFormatableToString_IFormatableToString_
    {
        [OuterLoop]
        [Fact]
        public void _system_iformatable_IFormatableToString_IFormatableToString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\iformatable\\IFormatableToString\\IFormatableToString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
