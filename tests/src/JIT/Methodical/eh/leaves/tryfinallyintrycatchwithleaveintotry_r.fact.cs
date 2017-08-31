using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_tryfinallyintrycatchwithleaveintotry_r_tryfinallyintrycatchwithleaveintotry_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_tryfinallyintrycatchwithleaveintotry_r_tryfinallyintrycatchwithleaveintotry_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\tryfinallyintrycatchwithleaveintotry_r\\tryfinallyintrycatchwithleaveintotry_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
