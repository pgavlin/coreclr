using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _intrinsic_interlocked_nullchecksuppress_nullchecksuppress_
    {
        [OuterLoop]
        [Fact]
        public void _intrinsic_interlocked_nullchecksuppress_nullchecksuppress_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\intrinsic\\interlocked\\nullchecksuppress\\nullchecksuppress.cmd");
        }
    }
}
