using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_char_CharIConvertibleToSByte_CharIConvertibleToSByte_
    {
        [OuterLoop]
        [Fact]
        public void _system_char_CharIConvertibleToSByte_CharIConvertibleToSByte_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\char\\CharIConvertibleToSByte\\CharIConvertibleToSByte.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
