using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _Arrays_misc__relselfref__relselfref_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__relselfref__relselfref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_relselfref\\_relselfref.cmd");
        }
    }
}
