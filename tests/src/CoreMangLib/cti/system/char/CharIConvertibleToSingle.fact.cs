using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIConvertibleToSingle_CharIConvertibleToSingle_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIConvertibleToSingle_CharIConvertibleToSingle_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIConvertibleToSingle\\CharIConvertibleToSingle.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
