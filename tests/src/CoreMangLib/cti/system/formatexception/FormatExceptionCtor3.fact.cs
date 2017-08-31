using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_formatexception_FormatExceptionCtor3_FormatExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_formatexception_FormatExceptionCtor3_FormatExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\formatexception\\FormatExceptionCtor3\\FormatExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
