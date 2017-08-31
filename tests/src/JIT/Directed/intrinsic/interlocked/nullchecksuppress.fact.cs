using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _intrinsic_interlocked_nullchecksuppress_nullchecksuppress_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_nullchecksuppress_nullchecksuppress_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\nullchecksuppress\\nullchecksuppress.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
