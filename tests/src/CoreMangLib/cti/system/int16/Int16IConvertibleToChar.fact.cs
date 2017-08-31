using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int16_Int16IConvertibleToChar_Int16IConvertibleToChar_
    {
        [OuterLoop]
        [Fact]
        public void _system_int16_Int16IConvertibleToChar_Int16IConvertibleToChar_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int16\\Int16IConvertibleToChar\\Int16IConvertibleToChar.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
