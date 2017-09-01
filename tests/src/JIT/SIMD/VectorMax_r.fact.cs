using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorMax_r_VectorMax_r_
    {
        [Fact]
        public void _VectorMax_r_VectorMax_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMax_r\\VectorMax_r.cmd");
        }
    }
}
