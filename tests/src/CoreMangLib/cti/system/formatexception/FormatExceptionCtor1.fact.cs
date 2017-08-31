using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_formatexception_FormatExceptionCtor1_FormatExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_formatexception_FormatExceptionCtor1_FormatExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\formatexception\\FormatExceptionCtor1\\FormatExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
