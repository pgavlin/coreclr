using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_tryfinallyintrycatchwithleaveintotry_d_tryfinallyintrycatchwithleaveintotry_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_tryfinallyintrycatchwithleaveintotry_d_tryfinallyintrycatchwithleaveintotry_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\tryfinallyintrycatchwithleaveintotry_d\\tryfinallyintrycatchwithleaveintotry_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
