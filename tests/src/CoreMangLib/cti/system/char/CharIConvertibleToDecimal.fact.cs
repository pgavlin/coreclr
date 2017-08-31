using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIConvertibleToDecimal_CharIConvertibleToDecimal_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIConvertibleToDecimal_CharIConvertibleToDecimal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIConvertibleToDecimal\\CharIConvertibleToDecimal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
