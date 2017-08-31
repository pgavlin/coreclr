using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIConvertibleToInt32_CharIConvertibleToInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIConvertibleToInt32_CharIConvertibleToInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIConvertibleToInt32\\CharIConvertibleToInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
