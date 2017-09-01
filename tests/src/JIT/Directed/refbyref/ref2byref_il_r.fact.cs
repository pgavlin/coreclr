using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _refbyref_ref2byref_il_r_ref2byref_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _refbyref_ref2byref_il_r_ref2byref_il_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\refbyref\\ref2byref_il_r\\ref2byref_il_r.cmd");
        }
    }
}
