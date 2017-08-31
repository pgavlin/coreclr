using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_formatexception_FormatExceptionCtor2_FormatExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_formatexception_FormatExceptionCtor2_FormatExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\formatexception\\FormatExceptionCtor2\\FormatExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
