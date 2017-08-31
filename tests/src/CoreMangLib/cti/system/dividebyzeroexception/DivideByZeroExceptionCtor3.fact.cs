using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_dividebyzeroexception_DivideByZeroExceptionCtor3_DivideByZeroExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_dividebyzeroexception_DivideByZeroExceptionCtor3_DivideByZeroExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\dividebyzeroexception\\DivideByZeroExceptionCtor3\\DivideByZeroExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
