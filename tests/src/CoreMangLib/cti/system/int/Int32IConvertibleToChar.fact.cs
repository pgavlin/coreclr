using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_int_Int32IConvertibleToChar_Int32IConvertibleToChar_
    {
        [OuterLoop]
        [Fact]
        public void _system_int_Int32IConvertibleToChar_Int32IConvertibleToChar_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\int\\Int32IConvertibleToChar\\Int32IConvertibleToChar.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
