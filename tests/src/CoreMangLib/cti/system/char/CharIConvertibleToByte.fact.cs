using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIConvertibleToByte_CharIConvertibleToByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIConvertibleToByte_CharIConvertibleToByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIConvertibleToByte\\CharIConvertibleToByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
