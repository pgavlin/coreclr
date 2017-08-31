using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_dividebyzeroexception_DivideByZeroExceptionCtor_DivideByZeroExceptionCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_dividebyzeroexception_DivideByZeroExceptionCtor_DivideByZeroExceptionCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\dividebyzeroexception\\DivideByZeroExceptionCtor\\DivideByZeroExceptionCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
