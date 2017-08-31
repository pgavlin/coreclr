using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIConvertibleToUInt32_CharIConvertibleToUInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIConvertibleToUInt32_CharIConvertibleToUInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIConvertibleToUInt32\\CharIConvertibleToUInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
