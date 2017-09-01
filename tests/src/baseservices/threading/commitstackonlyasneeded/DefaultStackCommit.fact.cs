using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _commitstackonlyasneeded_DefaultStackCommit_DefaultStackCommit_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _commitstackonlyasneeded_DefaultStackCommit_DefaultStackCommit_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\commitstackonlyasneeded\\DefaultStackCommit\\DefaultStackCommit.cmd");
        }
    }
}
