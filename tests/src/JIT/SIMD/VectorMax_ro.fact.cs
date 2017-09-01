using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorMax_ro_VectorMax_ro_
    {
        [Fact]
        public void _VectorMax_ro_VectorMax_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorMax_ro\\VectorMax_ro.cmd");
        }
    }
}
