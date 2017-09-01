using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Arrays_misc__speed_relselfref__speed_relselfref_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__speed_relselfref__speed_relselfref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_speed_relselfref\\_speed_relselfref.cmd");
        }
    }
}
