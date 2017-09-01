using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructABI_structfieldparam_r_structfieldparam_r_
    {
        [OuterLoop]
        [Fact]
        public void _StructABI_structfieldparam_r_structfieldparam_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructABI\\structfieldparam_r\\structfieldparam_r.cmd");
        }
    }
}
