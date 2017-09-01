using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Vector3GetHash_r_Vector3GetHash_r_
    {
        [OuterLoop]
        [Fact]
        public void _Vector3GetHash_r_Vector3GetHash_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3GetHash_r\\Vector3GetHash_r.cmd");
        }
    }
}
