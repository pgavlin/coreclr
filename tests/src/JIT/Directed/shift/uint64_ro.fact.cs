using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _shift_uint64_ro_uint64_ro_
    {
        [OuterLoop]
        [Fact]
        public void _shift_uint64_ro_uint64_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\shift\\uint64_ro\\uint64_ro.cmd");
        }
    }
}
