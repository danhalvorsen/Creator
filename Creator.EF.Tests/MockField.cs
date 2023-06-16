using AutoFixture;
using Creator.EF.Model.Fields;

namespace Creator.EF.Tests {
	public static class MockField {

		public static IntField Create() {
			Fixture fixture = new Fixture();
			fixture.Customize<IntField>(f => f.With(n => n.FieldName,"autofixtureNameTest"));
			fixture.Customize<IntField>(f => f.With(n => n.Description,"This is a description"));
			fixture.Customize<IntField>(f => f.With(n => n.NotNull,true));

			return fixture.Create<IntField>();
		}
	}

}
