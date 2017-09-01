using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Vector3GetHash_ro_Vector3GetHash_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Vector3GetHash_ro_Vector3GetHash_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3GetHash_ro\\Vector3GetHash_ro.cmd");
        }
    }
}
