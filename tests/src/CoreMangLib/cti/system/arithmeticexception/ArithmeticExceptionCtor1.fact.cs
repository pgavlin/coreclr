using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_arithmeticexception_ArithmeticExceptionCtor1_ArithmeticExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_arithmeticexception_ArithmeticExceptionCtor1_ArithmeticExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\arithmeticexception\\ArithmeticExceptionCtor1\\ArithmeticExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
